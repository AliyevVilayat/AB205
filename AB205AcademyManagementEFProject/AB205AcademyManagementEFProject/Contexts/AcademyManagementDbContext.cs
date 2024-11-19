using AB205AcademyManagementEFProject.Helpers;
using AB205AcademyManagementEFProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AB205AcademyManagementEFProject.Contexts;

public class AcademyManagementDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(SqlHelper.GetConnectionStrForMsSql());
        base.OnConfiguring(optionsBuilder);
    }
}
