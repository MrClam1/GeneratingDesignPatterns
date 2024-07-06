namespace AbstractFactory.Public.Object;

public abstract class PickUpAbleObject: IObject, IPickUpAble
{
    public uint Id { get; protected init; }
    public string Name { get; protected init; } = string.Empty;
    public int X { get; private set; }
    
    public void Spawn(int x)
    {
        X = x;
    }

    public void Destroy()
    {
        // delete object
    }

    public void PickUp()
    {
        // create copy of object
        
        Destroy();
    }
}