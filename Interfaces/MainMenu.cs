namespace RPG.Interfaces;

public class MainMenu
{

    private RootPanel Panel = new ();
    
    // Initialiseur
    public MainMenu()
    {
        Console.Clear();
        Panel.GamePresentation();
        Panel.CharacterCreation();
    }

    // Methode pour afficher un texte formatté
    public string LineMsgFormat(string? hexColor = "", string? message = "")
    {
        switch (hexColor)
        {
            case "green":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(message);
                Console.WriteLine("-------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine(message);
                Console.WriteLine("-------------------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "yellow":
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(message);
                Console.WriteLine("-------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(message);
                Console.WriteLine("-------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "dmagenta":
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(message);
                Console.WriteLine("-------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "white":
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(message);
                Console.WriteLine("-------------------------------------\n");
                break;
        }

        return "";
    }
}