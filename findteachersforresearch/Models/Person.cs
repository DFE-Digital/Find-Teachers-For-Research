using System.ComponentModel.DataAnnotations;

namespace findteachersforresearch.Models;


    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        public string Nino { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string ReferenceNumber { get; set; }
        
        public string EmailPersonal { get; set; }
        
        public string EmailWork { get; set; }
        
        public string Gender { get; set; }
        
        public bool OptedOutOfResearch { get; set; } 
        public ICollection<Employment> Employments { get; set; }
        
        public ICollection<ProfStatus> ProfStatuses { get; set; }
        
        public ICollection<Qualification> Qualifications { get; set; }
        
        public ICollection<ResearchRound> ResearchRounds { get; set; }
    }
