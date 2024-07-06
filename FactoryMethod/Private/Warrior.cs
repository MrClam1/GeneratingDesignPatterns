using FactoryMethod.Public;

namespace FactoryMethod.Private;

internal class Warrior: IPerson
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

    public Warrior(int strength, int agility, int intelligence)
    {
        Strength = strength;
        Agility = agility;
        Intelligence = intelligence;

        Attack = strength * 10d;
        SpeedAttack = Agility * 1.5d;
        SpeedMove = 1d;

        MaxHealth = strength * 100d;
        MaxMana = intelligence * 100d;

        Health = MaxHealth;
        Mana = MaxMana;
    }
}