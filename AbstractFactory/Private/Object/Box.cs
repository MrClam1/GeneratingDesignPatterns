using AbstractFactory.Public.Object;

namespace AbstractFactory.Private.Object;

internal class Box: MoveAbleObject
{
    public Box(uint id)
    {
        Id = id;
        Name = "Box";
    }
}