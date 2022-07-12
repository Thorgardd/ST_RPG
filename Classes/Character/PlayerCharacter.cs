namespace RPG.Classes.Character;

public class PlayerCharacter : BaseEntity
{
    private readonly Random _random = new ();
    
    public PlayerCharacter()
    {
        
    }

    public PlayerCharacter(string name, string description)
    {
        Name = name;
        Description = description;
        Xp = 0;
        Health = 50;
        Stamina = 100;
        ActionPoints = 3;
        Level = 1;
        AttackPoints = _random.Next(1, 10);
    }
}