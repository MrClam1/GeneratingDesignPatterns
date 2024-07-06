using AbstractFactory.Private;

namespace AbstractFactory.Public;

public sealed class ObjectFactory
{
    private readonly IMoveAbleObjectFactory _moveAbleObjectFactory = new MoveAbleObjectFactory();
    private readonly IPickUpObjectFactory _pickUpObjectFactory = new PickUpObjectFactory();

    public IMoveAbleObjectFactory GetMoveAbleObjectFactory() => _moveAbleObjectFactory;
    public IPickUpObjectFactory GetPickUpObjectFactory() => _pickUpObjectFactory;
}