using FactoryMethod.Public;

namespace GeneratingDesignPatterns;

public class FactoryMethodExample
{
    public static void Start()
    {
        var warrior = PersonFactory.CreateWarrior(0, 0, 0);
        var archer = PersonFactory.CreateArcher(0, 0, 0);
        var mage = PersonFactory.CreateMage(0, 0);
        
        Console.WriteLine("Warrior Info");
        Console.WriteLine($"Strength: {warrior.Strength}");
        Console.WriteLine($"Agility: {warrior.Agility}");
        Console.WriteLine($"Intelligence: {warrior.Intelligence}");
        Console.WriteLine("");
        
        Console.WriteLine("Archer Info");
        Console.WriteLine($"Strength: {archer.Strength}");
        Console.WriteLine($"Agility: {archer.Agility}");
        Console.WriteLine($"Intelligence: {archer.Intelligence}");
        Console.WriteLine("");
        
        Console.WriteLine("Mage Info");
        Console.WriteLine($"Strength: {mage.Strength}");
        Console.WriteLine($"Agility: {mage.Agility}");
        Console.WriteLine($"Intelligence: {mage.Intelligence}");
        Console.WriteLine("");
    }
}