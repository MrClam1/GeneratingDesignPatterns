namespace Builder.Public.Test;

public class Question(uint id, string name, string description, IEnumerator<string> answers, string correctAnswer)
{
    public uint Id { get; init; } = id;
    public string Name { get; init; } = name;
    public string Description { get; init; } = description;

    public IEnumerator<string> Answers { get; init; } = answers;
    public string CorrectAnswer { get; init; } = correctAnswer;
}