using AbstractFactory.Public.Object;

namespace AbstractFactory.Private.Object;

internal class Car: MoveAbleObject
{
    public Car(uint id)
    {
        Id = id;
        Name = "Car";
    }
}