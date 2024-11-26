namespace Pronia.DAL.Helpers;

public static class SqlHelper
{
    private static readonly string _connectionStr = @"Server=localhost;Database=ProniaProjectDB;Trusted_Connection=True;TrustServerCertificate=True;";


    public static string GetConnectionString()
    {
        return _connectionStr;
    }
}
