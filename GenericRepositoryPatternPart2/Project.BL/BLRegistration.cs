using Microsoft.Extensions.DependencyInjection;
using Project.BL.Profiles;
using Project.BL.Services.Abstractions;
using Project.BL.Services.Concretes;

namespace Project.BL;

public static class BLRegistration
{
    public static void AddBLServices(this IServiceCollection services)
    {
        //Scopes
        services.AddScoped<IPatientService, PatientService>();

        //AutoMapper
        services.AddAutoMapper(typeof(PatientProfile).Assembly);
    }
}
