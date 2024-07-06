using AbstractFactory.Public.Object;

namespace AbstractFactory.Public;

public interface IPickUpObjectFactory
{
    public PickUpAbleObject CreateApple();
    public PickUpAbleObject CreateBanana();
}