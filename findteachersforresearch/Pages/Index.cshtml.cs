using System.Security.Claims;
using findteachersforresearch.Data;
using findteachersforresearch.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.Json;

namespace findteachersforresearch.Pages;

[Authorize]
public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Person> Persons { get; set; } = new List<Person>();
    public string SearchString { get; set; }
    public List<string> FilterProfStatuses { get; set; } = new List<string>();
    public List<string> FilterQualifications { get; set; } = new List<string>();
    public int RecordCount { get; set; } = 60;
    public int MaxRecordCount { get; set; }
        
    public string UserName { get; private set; }
    public string UserEmail { get; private set; }
    
    // Selected ProfStatusName
    [BindProperty(SupportsGet = true)]
    public ProfStatus.ProfStatusName SelectedProfStatus { get; set; } = Models.ProfStatus.ProfStatusName.Qualified;
    
    // Selected NPQ Group
    [BindProperty(SupportsGet = true)]
    public NPQGroups? SelectedNPQGroup { get; set; } = null;
    
    public enum NPQGroups
    {
        Leadership,
        Specialised
    }
    
    public List<ResearchRound> AvailableResearchRounds {get; set;}
    
    public enum QualificationNames
    {
        QTS,
        EYTS,
        MQ,
        NPQML,
        NPQLTD,
        NPQLBC,
        NPQSL,
        NPQH,
        NPQEL
    }
    
    public enum ProfStatusNames
    {
        Qualified,
        Unqualified,
        Trainee
    }
    public IEnumerable<QualificationNames> QualificationNamesList { get; set; }
    public IEnumerable<ProfStatusNames> ProfStatusNamesList { get; set; }
    
    public void OnGet(string searchString, List<string> filterProfStatuses, List<string> filterQualifications, int? recordCount)
    {
        if (User.Identity.IsAuthenticated)
        {
            // Retrieve the user's name
            UserName = User.FindFirstValue("name");

            // Retrieve the user's email
            UserEmail = User.FindFirstValue("preferred_username");
        }
        
        SearchString = searchString;
        FilterProfStatuses = filterProfStatuses ?? new List<string>();
        FilterQualifications = filterQualifications ?? new List<string>();
        RecordCount = recordCount ?? 30;
        
        QualificationNamesList = Enum.GetValues(typeof(QualificationNames)).Cast<QualificationNames>();
        ProfStatusNamesList = Enum.GetValues(typeof(ProfStatusNames)).Cast<ProfStatusNames>();
        
        var profStatus = SelectedProfStatus;
        var npqGroup = SelectedNPQGroup;

        IQueryable<Person> query = _context.Persons;
        
        if (npqGroup != null)
        {   
            if (npqGroup == NPQGroups.Leadership)
            {
                query = _context.Persons
                    .Include(p => p.ProfStatus)
                    .Include(p => p.Qualification)
                    .Include(p => p.Employments)
                    .Include(p => p.ResearchRounds)
                    .Where(p => p.OptedOutOfResearch == false)
                    .Where(p => p.ResearchRounds.Count == 0)
                    .Where(p => p.ProfStatus.StatusName == profStatus)
                    .Where(p => p.Qualification.NPQSL > 0 || p.Qualification.NPQH > 0 || p.Qualification.NPQEL > 0);;
            }
            if (npqGroup == NPQGroups.Specialised)
            {
                query = _context.Persons
                    .Include(p => p.ProfStatus)
                    .Include(p => p.Qualification)
                    .Include(p => p.Employments)
                    .Include(p => p.ResearchRounds)
                    .Where(p => p.OptedOutOfResearch == false)
                    .Where(p => p.ResearchRounds.Count == 0)
                    .Where(p => p.ProfStatus.StatusName == profStatus)
                    .Where(p => p.Qualification.NPQLTD > 0 || p.Qualification.NPQLBC > 0 || p.Qualification.NPQML > 0);;
            }

        }
        else
        {
            query = _context.Persons
                .Include(p => p.ProfStatus)
                .Include(p => p.Qualification)
                .Include(p => p.Employments)
                .Include(p => p.ResearchRounds)
                .Where(p => p.OptedOutOfResearch == false)
                .Where(p => p.ResearchRounds.Count == 0)
                .Where(p => p.ProfStatus.StatusName == profStatus);
        }
        
        if (!string.IsNullOrEmpty(SearchString))
        {
            //query = query.Where(p => p.FirstName.Contains(SearchString) || p.LastName.Contains(SearchString));
            query = query.Where(p => EF.Functions.Like(p.FirstName, $"%{searchString}%") || 
                                            EF.Functions.Like(p.LastName, $"%{searchString}%") ||
                                            EF.Functions.Like(p.ReferenceNumber, $"%{searchString}%")) ;
        }

        if (FilterProfStatuses != null && FilterProfStatuses.Any())
        {
           query = query.Where(p =>
               (FilterProfStatuses.Equals("Qualified") &&
                p.ProfStatus.StatusName == ProfStatus.ProfStatusName.Qualified) ||
               (FilterProfStatuses.Contains("Unqualified") &&
                p.ProfStatus.StatusName == ProfStatus.ProfStatusName.Unqualified) ||
               (FilterProfStatuses.Contains("Trainee") && p.ProfStatus.StatusName == ProfStatus.ProfStatusName.Trainee)
           );
        }
        
        if (FilterQualifications != null && FilterQualifications.Any())
        {
            query = query.Where(p =>
                (FilterQualifications.Contains("MQ") && p.Qualification.MQ > 0) ||
                (FilterQualifications.Contains("NPQML") && p.Qualification.NPQML > 0) ||
                (FilterQualifications.Contains("NPQLTD") && p.Qualification.NPQLTD > 0) ||
                (FilterQualifications.Contains("NPQLBC") && p.Qualification.NPQLBC > 0) ||
                (FilterQualifications.Contains("NPQSL") && p.Qualification.NPQSL > 0) ||
                (FilterQualifications.Contains("NPQH") && p.Qualification.NPQH > 0) ||
                (FilterQualifications.Contains("NPQEL") && p.Qualification.NPQEL > 0)
            );

        }

        MaxRecordCount = query.Count();
        Persons = query.Take(RecordCount).ToList();
            
        AvailableResearchRounds = _context.ResearchRounds.ToList();
    }
    
    public IActionResult OnPost([FromForm] string selectedPersonIds, int researchRoundId)
    {
        if (!ModelState.IsValid)
        {
            Console.WriteLine("Model State Errors:");
            foreach (var modelStateKey in ModelState.Keys)
            {
                var modelStateVal = ModelState[modelStateKey];
                foreach (var error in modelStateVal.Errors)
                {
                    Console.WriteLine($"Key: {modelStateKey}, Error: {error.ErrorMessage}");
                }
            }
            return BadRequest(ModelState); // Return a 400 with model state errors
        }

        if (!string.IsNullOrEmpty(selectedPersonIds) && researchRoundId > 0)
        {
            var ids = selectedPersonIds.Split(',');
            var researchRound = _context.ResearchRounds.Include(r => r.Persons).FirstOrDefault(r => r.Id == researchRoundId);
            var personsToAdd = _context.Persons.Where(p => selectedPersonIds.Contains(p.PersonId)).ToList();

            if (researchRound != null && personsToAdd.Any())
            {
                foreach (var person in personsToAdd)
                {
                    if (!researchRound.Persons.Any(p => p.Id == person.Id))
                    {
                        researchRound.Persons.Add(person);
                    }
                }

                _context.SaveChanges();
            }
        }
        return RedirectToPage("/ResearchRounds");
    }
}