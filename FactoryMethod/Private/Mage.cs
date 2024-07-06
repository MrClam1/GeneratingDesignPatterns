using FactoryMethod.Public;

namespace FactoryMethod.Private;

internal class Mage: IPerson
{
    public int Strength { get; }
    public int Agility { get; }
    public int Intelligence { get; }
    public double Attack { get; }
    public double SpeedAttack { get; }
    public double SpeedMove { get; }
    public double Health { get; }
    public double MaxHealth { get; }
    public double Mana { get; }
    public double MaxMana { get; }
    
    public Mage(int agility, int intelligence)
    {
        Strength = 0;
        Agility = agility;
        Intelligence = intelligence;

        Attack = intelligence * 5d;
        SpeedAttack = Agility * 3d;
        SpeedMove = Agility * 1d;

        MaxHealth = intelligence * 60d;
        MaxMana = intelligence * 180d;

        Health = MaxHealth;
        Mana = MaxMana;
    }
}