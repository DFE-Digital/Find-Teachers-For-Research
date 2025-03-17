using System.ComponentModel.DataAnnotations;

namespace findteachersforresearch.Models;

public class Qualification
{
    public enum QualificationName
    {
        QTS,
        EYTS,
        NPQ,
        QTLS
    }

    [Required]
    public int Id { get; set; }
    [Required]
    public int PersonId { get; set; } // Foreign key to Person
    
    [Required]
    public QualificationName Name{get; set;} //Change to enum
    
    [Required]
    public DateTime AwardDate {get; set;} 
    
}