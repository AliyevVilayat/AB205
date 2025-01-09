using Microsoft.EntityFrameworkCore;
using Project.DAL.Configurations;
using Project.DAL.Entities;
using Project.DAL.Entities.Common;

namespace Project.DAL.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {

    }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Insurance> Insurances { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PatientConfiguration).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries<AuditableEntity>();
        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = DateTime.Now;
            }
            else if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdateAt = DateTime.Now;
            }

        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
