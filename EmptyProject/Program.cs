namespace EmptyProject;

public static class Program
{
    public static async Task Main(string[] args)
    {
        string SQL = "SELECT * FROM Users WHERE " + args[0];

        Console.WriteLine("Executing SQL: " + SQL);
    }
}