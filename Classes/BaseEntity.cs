using RPG.Interfaces;
using RPG.Items;

namespace RPG.Classes;

public abstract class BaseEntity
{
    // Attributs de l'entité
    protected string? Name { get; set; }
    protected string? Description { get; set; }
    protected int Xp { get; set; }
    protected int Level { get; set; }
    protected List<Item>? Inventory { get; set; }
    protected int Health { get; set; }
    protected int Stamina { get; set; }
    protected int ActionPoints { get; set; }
    protected int AttackPoints { get; set; }


    // Methode pour attaquer un adversaire (Joueur vs Ennemi)
    public void Attack()
    {
    }

    // Methode pour déclancher la mort du personnage
    private void OnKilled()
    {
    }

    // Methode pour soigner un personnage
    public void Heal(int healValue)
    {
    }

    // Methode pour ajouter un objet du sac à dos
    public void AddItem()
    {
    }

    // Methode pour retirer un objet du sac à dos
    public void RemoveItem()
    {
    }

    // Methode pour afficher le sac à dos
    public void ShowBackpack()
    {
    }


    // Methode pour afficher le sac à dos
    public void GetCharacterInfos()
    {
    }
}