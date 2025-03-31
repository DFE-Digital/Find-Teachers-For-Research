using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace findteachersforresearch.Models;


    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string PersonId { get; set; }
        
        [Required]
        public string ReferenceNumber { get; set; }

        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        public string EmailPersonal { get; set; }
        
        public string EmailWork { get; set; }
        
        public string Nino { get; set; }
        
        //public string Gender { get; set; }
        
        public bool OptedOutOfResearch { get; set; } 
        public ICollection<Employment> Employments { get; set; }
        
       // public ICollection<ProfStatus> ProfStatuses { get; set; }
        
        //public ICollection<Qualification> Qualifications { get; set; }
        // Navigation property for 1-to-1 Qualification
        public Qualification Qualification { get; set; }
      
        //public ICollection<ProfStatus> ProfStatus { get; set; }
        // Navigation property for 1-to-1 ProfStatus
        public ProfStatus ProfStatus { get; set; }
        public ICollection<ResearchRound> ResearchRounds { get; set; }
    }
