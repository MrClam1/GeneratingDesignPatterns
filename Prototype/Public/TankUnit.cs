namespace Prototype.Public;

public class TankUnit: IUnitPrototype
{
    public Guid Guid { get; init; }
    public string Name { get; init; }
    
    public int X { get; private set; }
    public int Attack { get; private set; }

    public TankUnit(int x, int attack)
    {
        Guid = Guid.NewGuid();
        Name = "Tank Unit";
        
        X = x;
        Attack = attack;
    }
    
    public void Move()
    {
        X++;
    }

    public IUnitPrototype Clone()
    {
        return new TankUnit(X, Attack);
    }
}