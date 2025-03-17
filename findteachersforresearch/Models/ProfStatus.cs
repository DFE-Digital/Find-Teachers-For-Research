using System.ComponentModel.DataAnnotations;

namespace findteachersforresearch.Models;

public class ProfStatus
{
    public enum ProfStatusName
    {
        Qualified,
        Unqualified,
        Trainee
    }
    [Required]
    public int Id { get; set; }
    [Required]
    public int PersonId { get; set; } // Foreign key to Person
    
    public ProfStatusName StatusName { get; set; } 
    
    public string? ITTCourse { get; set; } 
    
    public DateTime? ITTStartDate { get; set; } 
    
}