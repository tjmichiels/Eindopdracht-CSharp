using Eindopdracht_CSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace Eindopdracht_CSharp.Data;

public class ZooDbContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Enclosure> Enclosures { get; set; }
    public DbSet<Zoo> Zoos { get; set; }

    public ZooDbContext(DbContextOptions<ZooDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure entity relationships
    }
}