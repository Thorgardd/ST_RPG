﻿namespace RPG.Interfaces;

public class MainMenu
{
    // Initialiseur
    public MainMenu()
    {
            Console.Clear();
            LineMsgFormat("red", "RPG STRANGER THINGS");
            LineMsgFormat("white", "Bienvenue dans l'univers de Stranger Things, \n" +
                                   "où il y règne une atmosphère pesante, et où vous pourrez y faire d'étranges découvertes.\n" +
                                   "Arriverez-vous à percer le mystère qui réside dans Hawkins ?");
            LineMsgFormat("green", "Tapez /help pour ouvrir le menu d'aide aux commandes");
    }

    public string GetCharName()
    {
            LineMsgFormat("yellow", "Veuillez renseigner votre nom");
            string name = Console.ReadLine();
            return name;
    }

    public string GetCharDesc()
    {
            LineMsgFormat("yellow", "Veuillez renseigner votre description");
            string description = Console.ReadLine();
            return description;
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