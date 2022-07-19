using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using RPG.Classes.Character;
using RPG.Interfaces;
using RPG.Items;

namespace RPG;

internal class Program
{
    private static MainMenu MainMenu { get; set; }
    public static void Main(string[] args)
    {
        MainMenu = new MainMenu();
        Commands(Console.ReadLine());
    }

    // Methode pour checker les commandes entrées par l'utilisateur
    private static void Commands(string? args)
    {
        if (args == "/help") Console.WriteLine("/help");

        if (args == "/giveitem") Console.WriteLine("/giveitem");

        if (args == "/createitem") Console.WriteLine("/createitem");

        if (args == "/backpack") Console.WriteLine("/backpack");

        if (args == "/characterInfos") Console.WriteLine("/characterInfos");

        if (args == "/cls") Console.WriteLine("/cls");

        if (string.Join(" ", args) == "/heal") Console.WriteLine("/heal {value}");

        if (string.Join(" ", args) == "/give") Console.WriteLine("/give {item.name}");

        if (args == "" || args?.Length < 1) Console.WriteLine("Error command");

        if (args == "/exit") Environment.Exit(0);
    }
}