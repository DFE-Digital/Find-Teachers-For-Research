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
    public int PersonId { get; set; } // Foreign key to Person
    [Required]
    public string EstablishmentName { get; set; }
    
    [Required]
    public string EstablishmentTypeName { get; set; }
    [Required]
    public string EstablishmentTypeGroupName { get; set; }
    [Required]
    public string EstablishmentTown { get; set; }
    [Required]
    public string EstablishmentCounty { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    [Required]
    public DateTime LastSeenInTPSDate { get; set; }
    [Required]
    public string EmploymentType { get; set; }
    [Required]
    public string EstablishmentCode { get; set; }
    [Required]
    public string LaCode { get; set; }
    [Required]
    public string EstablishmentStatus { get; set; }
    [Required]
    public string EstablishmentSource { get; set; }
    }
