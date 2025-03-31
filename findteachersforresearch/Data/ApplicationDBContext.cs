using Microsoft.EntityFrameworkCore;
using findteachersforresearch.Models;

namespace findteachersforresearch.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Person> Persons => Set<Person>();
    public DbSet<ResearchRound> ResearchRounds => Set<ResearchRound>();
    
    public DbSet<Qualification> Qualifications { get; set; }

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>()
            .HasMany(p => p.ResearchRounds)
            .WithMany(r => r.Persons)
            .UsingEntity<Dictionary<string, object>>(
                "PersonResearchRound",
                j => j
                    .HasOne<ResearchRound>()
                    .WithMany()
                    .HasForeignKey("ResearchRoundsId"),
                j => j
                    .HasOne<Person>()
                    .WithMany()
                    .HasForeignKey("PersonsId"),
                j =>
                {
                    j.HasKey("PersonsId", "ResearchRoundsId");
                });
    }*/
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Person>()
            .HasMany(p => p.ResearchRounds)
            .WithMany(r => r.Persons)
            .UsingEntity<Dictionary<string, object>>(
                "PersonResearchRound",
                j => j
                    .HasOne<ResearchRound>()
                    .WithMany()
                    .HasForeignKey("ResearchRoundsId"),
                j => j
                    .HasOne<Person>()
                    .WithMany()
                    .HasForeignKey("PersonsId"),
                j => { j.HasKey("PersonsId", "ResearchRoundsId"); });
        
        modelBuilder.Entity<Person>()
            .HasKey(p => p.Id); // Primary key is "Id"

        // Define Person_Id as an alternate key
        modelBuilder.Entity<Person>()
            .HasAlternateKey(p => p.PersonId); // Alternate key is "Person_Id"

        // Define Qualification table's primary key
        modelBuilder.Entity<Qualification>()
            .HasKey(q => q.Id); // Primary key is "Id"

        // Map Qualification.Person_Id to Persons.Person_Id (alternate identifier) for one-to-one relationship
        modelBuilder.Entity<Qualification>()
            .HasOne(q => q.Person) // Navigation property in Qualification
            .WithOne(p => p.Qualification) // Navigation property in Person
            .HasForeignKey<Qualification>(q => q.PersonId) // Foreign key in Qualification referencing Person_Id
            .HasPrincipalKey<Person>(p => p.PersonId); // Principal key is Person.Person_Id
        
        
        // Define ProfStatus's primary key
        modelBuilder.Entity<ProfStatus>()
            .HasKey(ps => ps.Id);

        // Configure one-to-one relationship between Person and ProfStatus
        modelBuilder.Entity<ProfStatus>()
            .HasOne(ps => ps.Person)
            .WithOne(p => p.ProfStatus)
            .HasForeignKey<ProfStatus>(ps => ps.PersonId)
            .HasPrincipalKey<Person>(p => p.PersonId); // Principal key in Person
        
        // Configure Employment -> Person relationship
        modelBuilder.Entity<Employment>()
            .HasOne<Person>() // Employment is associated with one Person
            .WithMany(p => p.Employments) // A Person has many Employments
            .HasForeignKey(e => e.PersonId) // Set PersonId as the foreign key
            .HasPrincipalKey(p => p.PersonId); // Use PersonId as the principal key

    }
}