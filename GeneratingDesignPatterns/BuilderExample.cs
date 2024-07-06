using Builder.Public;

namespace GeneratingDesignPatterns;

public class BuilderExample
{
    public static void Start()
    {
        var mathExamBuilder = new MathExamBuilder();
        var mathTest = mathExamBuilder.CreateTest();

        var literatureExamBuilder = new LiteratureExamBuilder();
        var literatureTest = literatureExamBuilder.CreateTest();
        
        Console.WriteLine("Math Test Info");
        Console.WriteLine($"Guid: {mathTest.Guid}");
        Console.WriteLine($"Name: {mathTest.Name}");
        Console.WriteLine("");
        
        Console.WriteLine("Literature Test Info");
        Console.WriteLine($"Guid: {literatureTest.Guid}");
        Console.WriteLine($"Name: {literatureTest.Name}");
        Console.WriteLine("");
    }
}