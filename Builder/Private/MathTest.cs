using Builder.Public.Test;

namespace Builder.Private;

public class MathTest(IReadOnlyCollection<Question> questions) : ITest
{
    public Guid Guid { get; } = Guid.NewGuid();
    public string Name { get; } = "Math Test";
    public IReadOnlyCollection<Question> Questions { get; } = questions;

    public void Start()
    {
        ShowMaterial();
        
        for (var i = 0; i < Questions.Count; i++)
        {
            ShowQuestion(i);
        }
    }

    private void ShowMaterial()
    {
        // show material about questions
        
        Console.WriteLine("Math Test lasts 10 minutes. It is forbidden to use a calculator!");
    }

    private void ShowQuestion(int id)
    {
        // show questrion
        
        var question = Questions.ElementAt(id);
        
        Console.WriteLine($"Question name: {question.Name}");
        Console.WriteLine($"Question name: {question.Description}");
    }
}