using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Contexts;
using Project.DAL.Repositories.Abstractions;
using Project.DAL.Repositories.Concretes;

namespace Project.DAL;

public static class DALRegistration
{
    public static void AddServices(this IServiceCollection services, string connectionStr)
    {
        //DbContext
        services.AddDbContext<AppDbContext>(opt =>
        {
            // opt.UseSqlServer(Configurations.GetConnectionStr());
            opt.UseSqlServer(connectionStr);
        });

        //Scopes
        services.AddScoped<IPatientReadRepository, PatientReadRepository>();
        services.AddScoped<IPatientWriteRepository, PatientWriteRepository>();
    }
}
