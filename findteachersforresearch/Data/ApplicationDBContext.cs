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
                j =>
                {
                    j.HasKey("PersonsId", "ResearchRoundsId");
                });
    }
}