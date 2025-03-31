using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace findteachersforresearch.Models;

public class Employment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public int Id { get; set; }
    [Required]
    public string PersonId { get; set; } // Foreign key to Person
    
    public string? EstablishmentName { get; set; }
    public string? EstablishmentTypeGroupName { get; set; }
    public string? EmployerPostcode { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    [Required]
    public DateTime LastSeenInTPSDate { get; set; }
    public DateTime ExtractDate { get; set; }
    [Required]
    public string EmploymentType { get; set; }
    public string? WithdrawalConfirmed { get; set; }
    public string? Urn { get; set; }
    public string? EstablishmentStatus { get; set; }
    public string? EstablishmentSource { get; set; }
    public string? PhaseOfEducation { get; set; }
    public int NumberOfPupils { get; set; }
    public decimal FSMPercentage { get; set; }
    }
