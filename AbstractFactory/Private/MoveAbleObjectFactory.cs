using AbstractFactory.Private.Object;
using AbstractFactory.Public;
using AbstractFactory.Public.Object;

namespace AbstractFactory.Private;

internal class MoveAbleObjectFactory: IMoveAbleObjectFactory
{
    private uint _idObj;
    
    public MoveAbleObject CreateBox()
    {
        var obj = new Box(_idObj);
        _idObj++;

        return obj;
    }

    public MoveAbleObject CreateCar()
    {
        var obj = new Car(_idObj);
        _idObj++;

        return obj;
    }
}