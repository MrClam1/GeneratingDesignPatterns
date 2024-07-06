using FactoryMethod.Private;
using FactoryMethod.Public;

namespace GeneratingDesignPatterns;

public static class Program
{
    static void Main()
    {
        FactoryMethodExample.Start();
        AbstractFactoryExample.Start();
        BuilderExample.Start();
        PrototypeExample.Start();
    }
}