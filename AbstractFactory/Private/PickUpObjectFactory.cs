using AbstractFactory.Private.Object;
using AbstractFactory.Public;
using AbstractFactory.Public.Object;

namespace AbstractFactory.Private;

internal class PickUpObjectFactory: IPickUpObjectFactory
{
    private uint _idObj;

    public PickUpAbleObject CreateApple()
    {
        var obj = new Apple(_idObj);
        _idObj++;

        return obj;
    }

    public PickUpAbleObject CreateBanana()
    {
        var obj = new Banana(_idObj);
        _idObj++;

        return obj;
    }
}