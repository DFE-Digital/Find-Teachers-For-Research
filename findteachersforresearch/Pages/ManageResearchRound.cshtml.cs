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
    public void OnGet(int researchRoundId)
    {
        ResearchRound = _context.ResearchRounds.FirstOrDefault(rr => rr.Id == researchRoundId);

        if (ResearchRound == null) // Handle the case where the research round is not found
        {
            // Option 1: Redirect to an error page or display a message
            // return RedirectToPage("/Error"); // Or a custom error page

            // Option 2: Set Persons to an empty list to avoid further issues
            Persons = new List<Person>();
            return; // Important: Exit OnGet to prevent trying to query Persons with a null ResearchRound

        }
        
        Persons = _context.Persons
            .Where(p => p.ResearchRounds.Any(rr => rr.Id == researchRoundId))
            .Include(p => p.ProfStatuses)
            .Include(p => p.Qualifications)
            .ToList();
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
        return Page(); // Or BadRequest(ModelState);
    }

    int researchRoundId = ResearchRoundId; //stored in a hidden field in the page, it will get populated on submit as its bound.

    // Load the ResearchRound from the database
    ResearchRound = _context.ResearchRounds.FirstOrDefault(rr => rr.Id == researchRoundId);
    if(ResearchRound == null){
        return NotFound();
    }

    // Update ResearchRound.Type
    ResearchRound.Type = ResearchType;

    Persons = _context.Persons
        .Where(p => p.ResearchRounds.Any(rr => rr.Id == researchRoundId))
        .Include(p => p.ProfStatuses)
        .Include(p => p.Qualifications)
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
                {
                    var researchRoundToRemoveFrom = person.ResearchRounds.FirstOrDefault(rr => rr.Id == researchRoundId);
                    if (researchRoundToRemoveFrom != null)
                    {
                        person.ResearchRounds.Remove(researchRoundToRemoveFrom);
                    }
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
        // Handle the error appropriately
    }

    return RedirectToPage(new { researchRoundId = ResearchRoundId });
}
}