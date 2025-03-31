using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace findteachersforresearch.Models;

[Table("Qualification")]
public class Qualification
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public int Id { get; set; }
    [Required]
    public string PersonId { get; set; } // Foreign key to Person
    public Person Person { get; set; } // Navigation property
    public DateTime? QTSDate { get; set; }
    public DateTime? EYTSDate { get; set; }
    public int MQ { get; set; }
    public int NPQML { get; set; }
    public int NPQLTD { get; set; }
    public int NPQLBC { get; set; }
    public int NPQSL { get; set; }
    public int NPQH { get; set; }
    public int NPQEL { get; set; }
    
  
}