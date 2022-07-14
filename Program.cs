using System;
using System.ComponentModel.Design;
using RPG.Classes.Character;
using RPG.Interfaces;
using RPG.Items;

namespace RPG // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static MainMenu mainMenu { get; set; }
        public static PlayerCharacter playerCharacter { get; set; }
        
        public static Item item { get; set; }
        
        public static void Main(string[] args)
        {
             mainMenu = new MainMenu();
            
            string name = mainMenu.GetCharName();
            string description = mainMenu.GetCharDesc();
            playerCharacter = new PlayerCharacter(name, description);
            while (true)
            {
                mainMenu.LineMsgFormat("yellow","Veuillez taper votre commande de jeu :");
                Commands(Console.ReadLine());
            }
        }
        
        // Methode pour checker les commandes entrées par l'utilisateur
        private static void Commands(string? args)
        {
            if (args == "/help")
            {
                mainMenu?.LineMsgFormat("green", 
                    "Commandes disponibles en jeu\n" +
                    "/backpack                    Montre l'inventaire dans le sac à dos\n" +
                    "/help                        Montre les commandes disponibles\n" +
                    "/attack <Nom de l'ennemi>    Permet d'attaquer une cible\n" +
                    "/pickup <Nom de l'item>      Permet de ramasser un objet disponible\n" +
                    "/drop <Nom de l'item>        Permet de lâcher un objet présent dans le sac à dos\n" +
                    "/characterInfos              Permet de montrer les infos du personnage\n");
            }

            if (args == "/giveitem")
            {
                Item savedItem = new Item();
                playerCharacter.AddItem(savedItem);
            }

            if (args == "/createitem")
            {
                Item itemCreated = new Item();
                mainMenu.LineMsgFormat("red", $"Vous avez créé l'objet {itemCreated}");
            }

            if (args == "/backpack")
            {
                playerCharacter?.ShowBackpack();
            }

            if (args == "/characterInfos")
            {
                playerCharacter?.GetCharacterInfos();
            }

            if (args == "/cls")
            {
                Console.Clear();
            }

            if (string.Join(" ", args) == "/heal")
            {
                playerCharacter?.Heal(50);
                mainMenu?.LineMsgFormat("green","Vous vous êtes soignés complétement");
            }

            if (string.Join(" ", args) == "/give")
            {
                
            }

            if (args == "" || args?.Length < 1)
            {
                mainMenu?.LineMsgFormat("red", "Veuillez entrer une commande valide ou tapez /help pour avoir la liste des commandes\n");
            }

            if (args == "/exit")
            {
                Environment.Exit(0);
            }
        }
    }
}