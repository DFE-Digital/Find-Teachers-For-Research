using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace findteachersforresearch.Models;

public class ProfStatus
{
    public enum ProfStatusName
    {
        Qualified,
        Unqualified,
        Trainee
    }
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public int Id { get; set; }
    [Required]
    public string PersonId { get; set; } // Foreign key to Person
    
    public Person Person { get; set; } // Navigation property
    
    public ProfStatusName StatusName { get; set; } 
    
}