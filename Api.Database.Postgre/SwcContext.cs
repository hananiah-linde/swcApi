using Api.Database.Entity.Threats;
using Microsoft.EntityFrameworkCore;

namespace Api.Database.Postgre;

public class SwcContext : DbContext
{
    public SwcContext(DbContextOptions<SwcContext> options) : base(options) { }

    public DbSet<Threat> Threats { get; set; }
    public DbSet<ThreatType> Type { get; set; }
    public DbSet<Status> Status { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
