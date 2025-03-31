using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace findteachersforresearch.Models;

public class ResearchRound
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    
    public string? Description { get; set; }

    [Required]
    public string CreatedBy { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }
    
    [Required]
    public TypeOfResearchRound Type { get; set; }

    public ICollection<Person> Persons { get; set; } // Navigation property

    public enum TypeOfResearchRound
    {
        Screener,
        Normal,
    }
}