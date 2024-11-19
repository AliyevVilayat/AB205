namespace AB205AcademyManagementEFProject.Helpers;

public static class SqlHelper
{
    private static readonly string _connectionStrForMsSql = @"Server=localhost;Database=AB205AcademyDB;Trusted_Connection=True;TrustServerCertificate=True";

    public static string GetConnectionStrForMsSql()
    {
        return _connectionStrForMsSql;
    }
}
