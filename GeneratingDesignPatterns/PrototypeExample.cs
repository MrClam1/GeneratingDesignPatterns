using Prototype.Public;

namespace GeneratingDesignPatterns;

public class PrototypeExample
{
    public static void Start()
    {
        var soldier1 = new SoldierUnit(0, 1, Array.Empty<string>());
        var soldier2 = (SoldierUnit)soldier1.Clone();
        soldier2.Move();

        var listSoldier = new List<SoldierUnit> { soldier1, soldier2 };
        var artilleryA = new ArtilleryUnit(0, 10, 100, listSoldier);
        var artilleryB = (ArtilleryUnit)artilleryA.Clone();
        
        Console.WriteLine("Guid soldiers of artillery A:");
        foreach (var unit in artilleryA.Crew)
        {
            Console.WriteLine($"Guid: {unit.Guid}");
        }
        Console.WriteLine("");
        
        Console.WriteLine("Guid soldiers of artillery B:");
        foreach (var unit in artilleryB.Crew)
        {
            Console.WriteLine($"Guid: {unit.Guid}");
        }
        Console.WriteLine("");
    }
}