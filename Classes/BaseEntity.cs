using RPG.Interfaces;
using RPG.Items;

namespace RPG.Classes
{
    public class BaseEntity
{
     // Attributs de l'entité
        public string? Name { get; set; }
        public string? Description { get; set; }
        protected int Xp { get; set; }
        public int Level { get; set; }
        public List<Item>? Backpack { get; set; } = new List<Item>();
        public int BackpackMaxWeight = 10;
        public int BackpackWeight = 0;
        public int Health { get; protected set; }
        public int Stamina { get; protected set; }
        protected int ActionPoints { get; set; }
        protected int AttackPoints { get; set; }
        public MainMenu mainMenu { get; set; }

        
        // Methode pour attaquer un adversaire (Joueur vs Ennemi)
        public string Attack(BaseEntity foe)
        {
            foe.Health -= AttackPoints;
            if (foe.Health == 0)
            {
                foe.OnKilled();
            }
            return $"Vous avez attaqué {foe.Name}.\n{foe.Name} a perdu {AttackPoints} points de vie.\n" +
                   $"Il lui reste {foe.Health}";
        }

        // Methode pour déclancher la mort du personnage
        private void OnKilled()
        {
            if (Health >= 1)
            {
                Health = 0;
                mainMenu.LineMsgFormat("red", $"{Name} est mort");
            }
            mainMenu.LineMsgFormat("red", $"{Name} est déjà mort(e)");
        }

        // Methode pour soigner un personnage
        public void Heal(int healValue)
        {
            if (Health < 101)
            {
                Health += healValue;
            }
        }

        // Methode pour ajouter un objet du sac à dos
        public void AddItem(Item item)
        {
            if (item.Weight > BackpackMaxWeight)
            {
                mainMenu.LineMsgFormat("red", "L'Item est trop lourd pour être rangé dans le sac à dos");
                
            }
            
            Backpack?.Add(item);
            mainMenu.LineMsgFormat("green", $"Vous avez ajouté {item.Name} à votre sac à dos");
        }

        // Methode pour retirer un objet du sac à dos
        public void RemoveItem(Item item)
        {
            if (Backpack.Contains(item))
            {
                Backpack.Remove(item);
            }
            else
            {
                mainMenu.LineMsgFormat("red", "L'Item n'est pas dans votre sac à dos");
            }
        }

        // Methode pour afficher le sac à dos
        public void ShowBackpack()
        {
            mainMenu.LineMsgFormat("dmagenta", "Sac à dos");
            
            foreach (var item in Backpack)
            {
                mainMenu.LineMsgFormat($"dmagenta", $"{item.Name}\n{item.Weight}");
            }
            
            mainMenu.LineMsgFormat("yellow", $"Votre sac contient {Backpack.Count} objet(s) sur {BackpackMaxWeight} emplacements disponibles");
            mainMenu.LineMsgFormat("red", "Il n'y a aucun objet dans votre sac à dos");
        }
        
        
        // Methode pour afficher le sac à dos
        public void GetCharacterInfos()
        {
            mainMenu = new MainMenu();
            Console.Clear();
            mainMenu.LineMsgFormat("blue", "Voici vos informations de personnage : \n" +
                                                            $"Nom : {Name}\nDescription : {Description}\n" +
                                                            $"Vie : {Health} PV\n" +
                                                            $"Niveau : {Level}");
            
        }
}
}