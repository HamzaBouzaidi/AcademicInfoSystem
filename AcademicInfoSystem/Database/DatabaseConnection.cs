using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private static string _connectionString = "server=localhost;database=academicsystem;uid=root;pwd=Iloveshelly123?;";

    // ✅ GOOD: Returns a NEW connection each time
    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(_connectionString);
    }

    // ✅ Or use this method for convenience
    public static string GetConnectionString()
    {
        return _connectionString;
    }
}