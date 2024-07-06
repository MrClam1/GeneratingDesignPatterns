using FactoryMethod.Public;

namespace FactoryMethod.Private;

internal class Archer: IPerson
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
    
    public Archer(int strength, int agility, int intelligence)
    {
        Strength = strength;
        Agility = agility;
        Intelligence = intelligence;

        Attack = strength * 2d;
        SpeedAttack = Agility * 5d;
        SpeedMove = Agility * 2d;

        MaxHealth = strength * 50d;
        MaxMana = intelligence * 110d;

        Health = MaxHealth;
        Mana = MaxMana;
    }
}