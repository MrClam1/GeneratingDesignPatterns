namespace AbstractFactory.Public.Object;

public interface IObject
{
    public uint Id { get; }
    public string Name { get; }
    
    public int X { get; }
    
    public void Spawn(int x);
    public void Destroy();
}