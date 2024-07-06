namespace Prototype.Public;

public class SoldierUnit: IUnitPrototype
{
    public Guid Guid { get; init; }
    public string Name { get; init; }
    
    public int X { get; private set; }
    public int Attack { get; private set; }
    
    public IReadOnlyCollection<string> Items { get; init; }

    public SoldierUnit(int x, int attack, IReadOnlyCollection<string> items)
    {
        Guid = Guid.NewGuid();
        Name = "Soldier Unit";
        
        X = x;
        Attack = attack;
        Items = items;
    }
    
    public void Move()
    {
        X++;
    }

    public IUnitPrototype Clone()
    {
        var items = new List<string>(Items);

        return new SoldierUnit(X, Attack, items);
    }
}