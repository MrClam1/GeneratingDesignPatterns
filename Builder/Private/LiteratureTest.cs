using Builder.Public.Test;

namespace Builder.Private;

public class LiteratureTest(IReadOnlyCollection<Question> questions, IReadOnlyCollection<string> information): ITest
{
    public Guid Guid { get; } = Guid.NewGuid();
    public string Name { get; } = "Literature Test";
    public IReadOnlyCollection<Question> Questions { get; } = questions;
    public IReadOnlyCollection<string> Information { get; } = information;

    public void Start()
    {
        for (var i = 0; i < Questions.Count; i++)
        {
            ShowMaterial(i);
            ShowQuestion(i);
        }
    }

    private void ShowMaterial(int id)
    {
        // show information about current question
        
        Console.WriteLine($"Information: {Information.ElementAt(id)}");
    }

    private void ShowQuestion(int id)
    {
        // show questrion

        var question = Questions.ElementAt(id);
        
        Console.WriteLine($"Question name: {question.Name}");
        Console.WriteLine($"Question name: {question.Description}");
    }
}