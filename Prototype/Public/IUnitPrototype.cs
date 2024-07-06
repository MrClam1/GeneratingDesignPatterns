namespace Prototype.Public;

public interface IUnitPrototype
{
    public Guid Guid { get; }
    public string Name { get; }
    
    public int X { get; }
    public int Attack { get; }
    
    public void Move();
    
    public IUnitPrototype Clone();
}