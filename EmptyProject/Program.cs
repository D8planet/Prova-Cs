namespace EmptyProject;

public static class Program
{
    public static async Task Main()
    {
        string[] content = await File.ReadAllLinesAsync("C:\\Qusto\\file\\non_esiste.txt");

        Console.WriteLine("File contents:\n" + string.Join(Environment.NewLine, content));
    }
}