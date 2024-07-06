using AbstractFactory.Public.Object;

namespace AbstractFactory.Private.Object;

internal class Banana: PickUpAbleObject
{
    public Banana(uint id)
    {
        Id = id;
        Name = "Banana";
    }
}