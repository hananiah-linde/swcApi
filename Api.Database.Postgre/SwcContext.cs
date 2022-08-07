using Api.Database.Entity.Threats;
using Api.Database.Postgre.Configuration;
using Api.Database.Postgre.Constants;
using Microsoft.EntityFrameworkCore;

namespace Api.Database.Postgre;

public class SwcContext : DbContext
{
    public SwcContext(DbContextOptions<SwcContext> options) : base(options) { }

    public DbSet<Threat> Threats { get; set; }
    public DbSet<Entity.Threats.Type> Type { get; set; }
    public DbSet<Status> Status { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasPostgresExtension(PostgresExtensions.UUIDGenerator);
        modelBuilder.ApplyConfiguration(new StatusConfiguration());
        modelBuilder.ApplyConfiguration(new TypeConfiguration());
        modelBuilder.ApplyConfiguration(new ThreatConfiguration());
        modelBuilder.ApplyConfiguration(new ClassificationConfiguration());
    }
}
