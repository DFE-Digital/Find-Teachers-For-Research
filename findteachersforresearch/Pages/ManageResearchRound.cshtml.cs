using findteachersforresearch.Data;
using findteachersforresearch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace findteachersforresearch.Pages;

public class ManageResearchRound : PageModel
{
    private readonly ApplicationDbContext _context;
    public IList<Person> Persons { get; set; }
    public ResearchRound ResearchRound { get; set; }
    public ManageResearchRound(ApplicationDbContext context)
    {
        _context = context;
    }
    [BindProperty]
    public ResearchRound.TypeOfResearchRound ResearchType { get; set; }
    
    [BindProperty]  // Crucial: Bind the property
    public int ResearchRoundId { get; set; }
    public IActionResult OnGet(int researchRoundId)
    {
        ResearchRound = _context.ResearchRounds.FirstOrDefault(rr => rr.Id == researchRoundId);

        if (ResearchRound == null) 
        {
            Persons = new List<Person>();
            return NotFound(); 
        }
        Persons = _context.Persons
            .Where(p => p.ResearchRounds.Any(rr => rr.Id == researchRoundId) && !p.OptedOutOfResearch)
            .Include(p => p.ProfStatus)
            .Include(p => p.Qualification)
            .ToList();
        return Page();
    }
    
    
    public class PersonSelection
    {
        public int Id { get; set; }
        public bool IsSelected { get; set; } = false; 
        public bool OptedOut { get; set; } = false; 
        public bool Removed { get; set; } = false; 
    }

    [BindProperty]
    public List<PersonSelection> PersonSelections { get; set; } 
    
    public IActionResult OnPost()
{
    if (!ModelState.IsValid)
    {
        foreach (var modelStateKey in ModelState.Keys)
        {
            var modelStateVal = ModelState[modelStateKey];
            foreach (var error in modelStateVal.Errors)
            {
                Console.WriteLine($"Key: {modelStateKey}, Error: {error.ErrorMessage}");
            }
        }
        return Page(); 
    }

    int researchRoundId = ResearchRoundId; 

   
    ResearchRound = _context.ResearchRounds.FirstOrDefault(rr => rr.Id == researchRoundId);
    if(ResearchRound == null){
        return NotFound();
    }
    ResearchRound.Type = ResearchType;

    Persons = _context.Persons
        .Where(p => p.ResearchRounds.Any(rr => rr.Id == researchRoundId))
        .Include(p => p.ProfStatus)
        .Include(p => p.Qualification)
        .Include(p => p.ResearchRounds)
        .ToList();

    if (PersonSelections != null)
    {
        foreach (var selection in PersonSelections)
        {
            var person = Persons.FirstOrDefault(p => p.Id == selection.Id);
            if (person != null)
            {
                person.OptedOutOfResearch = selection.OptedOut;
                
                if (selection.Removed)
                    //Remove from round
                {
                    var researchRoundToRemoveFrom = person.ResearchRounds.FirstOrDefault(rr => rr.Id == researchRoundId);
                    if (researchRoundToRemoveFrom != null)
                    {
                        person.ResearchRounds.Remove(researchRoundToRemoveFrom);
                    }
                }

                if (person.OptedOutOfResearch)
                {
                    person.OptedOutOfResearch = selection.OptedOut;
                }
            }
        }
    }

    try
    {
        _context.SaveChanges();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Database error: {ex.Message}");
    }

    return RedirectToPage(new { researchRoundId = ResearchRoundId });
}
}