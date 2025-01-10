using Eindopdracht_CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Eindopdracht_CSharp.Data;

public class ZooDbContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Enclosure> Enclosures { get; set; }
    public DbSet<Zoo> Zoos { get; set; }

    public ZooDbContext(DbContextOptions<ZooDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Primary keys
        modelBuilder.Entity<Animal>()
            .HasKey(a => a.Id);

        // Animal -> Category
        modelBuilder.Entity<Animal>()
            .HasOne(a => a.Category)
            .WithMany(c => c.Animals)
            .OnDelete(DeleteBehavior.SetNull);

        // Animal -> Enclosure
        modelBuilder.Entity<Animal>()
            .HasOne(a => a.Enclosure)
            .WithMany(e => e.Animals)
            .OnDelete(DeleteBehavior.SetNull);

        // Enclosure -> Zoo
        modelBuilder.Entity<Enclosure>()
            .HasOne<Zoo>()
            .WithMany(z => z.Enclosures)
            .OnDelete(DeleteBehavior.Cascade);
    }
}