using AbstractFactory.Public;

namespace GeneratingDesignPatterns;

public class AbstractFactoryExample
{
    public static void Start()
    {
        var objectFactory = new ObjectFactory();

        var moveAbleObjectFactory = objectFactory.GetMoveAbleObjectFactory();
        var pickUpAbleObjectFactory = objectFactory.GetPickUpObjectFactory();

        var box = moveAbleObjectFactory.CreateBox();
        var car = moveAbleObjectFactory.CreateCar();

        var apple = pickUpAbleObjectFactory.CreateApple();
        var banana = pickUpAbleObjectFactory.CreateBanana();
        
        Console.WriteLine("MoveAbleObjects:");
        Console.WriteLine($"Box: {box.Id}, {box.Name}");
        Console.WriteLine($"Car: {car.Id}, {car.Name}");
        Console.WriteLine("");
        
        Console.WriteLine("PickUpObjects:");
        Console.WriteLine($"Apple: {apple.Id}, {apple.Name}");
        Console.WriteLine($"Banana: {banana.Id}, {banana.Name}");
        Console.WriteLine("");
    }
}