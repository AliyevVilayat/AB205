using Microsoft.Extensions.Configuration;

namespace Project.DAL.Helpers;

public class Configurations
{

    public static string GetConnectionStr()
    {

        ConfigurationManager configurationManager = new ConfigurationManager();
        configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "Project.API"));
        configurationManager.AddJsonFile("myCustomSettings.json");

        string? connectionStr = configurationManager.GetSection("MahirConnection")["Asus"];
        if (connectionStr is null)
        {

            throw new Exception("Connection String is null");
        }

        return connectionStr;
    }



}
