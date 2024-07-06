namespace FactoryMethod.Public;

public interface IPerson
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
}