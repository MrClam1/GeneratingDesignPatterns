using FactoryMethod.Private;

namespace FactoryMethod.Public;

public class PersonFactory
{
    public static IPerson CreateWarrior(int strength, int agility, int intelligence)
    {
        strength = strength.Clamp(10, 100);
        agility = agility.Clamp(5, 100);
        intelligence = intelligence.Clamp(0, 10);

        return new Warrior(strength, agility, intelligence);
    }

    public static IPerson CreateArcher(int strength, int agility, int intelligence)
    {
        strength = strength.Clamp(0, 10);
        agility = agility.Clamp(10, 200);
        intelligence = intelligence.Clamp(10, 80);

        return new Archer(strength, agility, intelligence);
    }

    public static IPerson CreateMage(int agility, int intelligence)
    {
        agility = agility.Clamp(10, 50);
        intelligence = intelligence.Clamp(10, 200);

        return new Mage(agility, intelligence);
    }
}