using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Contexts;

namespace Project.DAL;

public static class DALRegistration
{
    public static void AddServices(this IServiceCollection services, string connectionStr)
    {
        services.AddDbContext<AppDbContext>(opt =>
        {
            // opt.UseSqlServer(Configurations.GetConnectionStr());
            opt.UseSqlServer(connectionStr);
        });
    }
}
