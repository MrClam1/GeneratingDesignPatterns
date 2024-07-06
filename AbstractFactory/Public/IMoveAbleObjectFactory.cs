using AbstractFactory.Public.Object;

namespace AbstractFactory.Public;

public interface IMoveAbleObjectFactory
{
    public MoveAbleObject CreateBox();
    public MoveAbleObject CreateCar();
}