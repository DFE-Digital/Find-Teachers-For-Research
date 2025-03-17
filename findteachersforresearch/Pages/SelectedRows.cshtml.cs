using System.Security.Claims;
using findteachersforresearch.Data;
using findteachersforresearch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace findteachersforresearch.Pages;

public class SelectedRows : PageModel
{
    private readonly ApplicationDbContext _context;

    public SelectedRows(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Person> Persons { get; set; }

    [BindProperty]
    public string ResearchTitle { get; set; }

    [BindProperty]
    public ResearchRound.TypeOfResearchRound ResearchType { get; set; }
        
    public string UserName { get; private set; }
    public string UserEmail { get; private set; }
        
    [BindProperty]
    public string ResearchDescription { get; set; }
    public async Task OnGetAsync(string ids)
    {
        Persons = _context.Persons.ToList();

        if (!string.IsNullOrEmpty(ids))
        {
            var selectedIds = ids.Split(',')
                .Select(id => Convert.ToInt32(id))
                .ToList();

            Persons = Persons.Where(p => selectedIds.Contains(p.Id)).ToList();

            // Store the selected Person IDs in TempData
            TempData["SelectedPersonIds"] = string.Join(",", selectedIds);
        }
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // Retrieve selected person IDs from TempData
        var selectedIds = TempData["SelectedPersonIds"]?.ToString()
            .Split(',')
            .Select(id => Convert.ToInt32(id))
            .ToList();

        if (selectedIds == null || !selectedIds.Any())
        {
            // Handle the case where no persons are selected (for safety)
            return Page();
        }
        
        Persons = await _context.Persons
            .Where(p => selectedIds.Contains(p.Id))
            .Include(p => p.ResearchRounds)
            .ToListAsync();

        if (Persons == null || !Persons.Any())
        {
            return Page();
        }

        if (!string.IsNullOrEmpty(ResearchTitle))
        {
            if (User.Identity.IsAuthenticated)
            {
                // Retrieve the user's name
                UserName = User.FindFirstValue("name");

                // Retrieve the user's email
                UserEmail = User.FindFirstValue("preferred_username");
            }
            // Create a new ResearchRound object
            var newResearch = new ResearchRound
            {
                Name = ResearchTitle,
                CreatedDate = DateTime.UtcNow,
                Description = ResearchDescription,
                CreatedBy = UserEmail,
                Type = ResearchType,
                Persons = new List<Person>()
            };
            
            _context.ResearchRounds.Add(newResearch);
            await _context.SaveChangesAsync();
            
            foreach (var person in Persons)
            {
                if (person != null)
                {
                    person.ResearchRounds.Add(newResearch);
                }
            }

            await _context.SaveChangesAsync();
        }

        // Redirect to the ResearchRounds page
        return RedirectToPage("/ResearchRounds");
    }
}