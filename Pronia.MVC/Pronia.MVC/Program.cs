using Microsoft.EntityFrameworkCore;
using Pronia.BL.Services.Abstractions;
using Pronia.BL.Services.Concretes;
using Pronia.DAL.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

string? connectionStr = builder.Configuration.GetConnectionString("Asus");

builder.Services.AddDbContext<ProniaDBContext>(opt =>
{
    opt.UseSqlServer(connectionStr);
});

builder.Services.AddScoped<ISliderItemService, SliderItemService>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );

app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"

    );


app.Run();
