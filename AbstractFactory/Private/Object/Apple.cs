using AbstractFactory.Public.Object;

namespace AbstractFactory.Private.Object;

internal class Apple: PickUpAbleObject
{
    public Apple(uint id)
    {
        Id = id;
        Name = "Apple";
    }
}