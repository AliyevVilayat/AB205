using Microsoft.EntityFrameworkCore;
using Project.DAL.Configurations;
using Project.DAL.Entities;

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
}
