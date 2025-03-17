using findteachersforresearch.Data;
using findteachersforresearch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace findteachersforresearch.Pages;

public class ResearchRounds(ApplicationDbContext context) : PageModel
{
    public List<ResearchRound>? ResearchRoundList { get; set; } 

    [BindProperty(SupportsGet = true)] 
    public string? SearchString { get; set; } 
    [BindProperty(SupportsGet = true)] 
    public int SelectedRound { get; set; }
    public void OnGet()
    {
        IQueryable<ResearchRound> researchRounds = context.ResearchRounds;

        if (!string.IsNullOrEmpty(SearchString))
        {
            string searchTerm = $"%{SearchString}%"; 

            researchRounds = researchRounds.Where(r =>
                EF.Functions.Like(r.Name, searchTerm) ||
                EF.Functions.Like(r.Description, searchTerm) ||
                EF.Functions.Like(r.CreatedBy, searchTerm));
        }
        ResearchRoundList = researchRounds.ToList();
    }
}