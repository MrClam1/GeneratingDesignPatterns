namespace Prototype.Public;

public class ArtilleryUnit: IUnitPrototype
{
    public Guid Guid { get; }
    public string Name { get; }
    public int X { get; private set; }
    public int Attack { get; private set; }
    public int Duration { get; private set; }
    
    public IReadOnlyCollection<SoldierUnit> Crew { get; init; }

    public ArtilleryUnit(int x, int attack, int duration, IReadOnlyCollection<SoldierUnit> crew)
    {
        Guid = Guid.NewGuid();
        Name = "Artillery Unit";
        
        X = x;
        Attack = attack;
        Duration = duration;
        Crew = crew;
    }
    
    public void Move()
    {
        X++;
    }

    public IUnitPrototype Clone()
    {
        var crew = new List<SoldierUnit>();

        for (var i = 0; i < Crew.Count; i++)
        {
            var soldier = Crew.ElementAt(i);
            var newSoldier = (SoldierUnit)soldier.Clone();
            
            crew.Add(newSoldier);
        }
        
        return new ArtilleryUnit(X, Attack, Duration, crew);
    }
}