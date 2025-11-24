using TeamProjectC6.Menu_s;

/// <summary>
/// Main program entry point.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        MainMenu mainMenu = new MainMenu();
        mainMenu.Run();
        Console.WriteLine("Goodbye!");
    }
}
