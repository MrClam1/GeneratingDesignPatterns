namespace Builder.Public.Test;

public interface ITest
{
    public Guid Guid { get; }
    public string Name { get; }
    public IReadOnlyCollection<Question> Questions { get; }

    public void Start();
}