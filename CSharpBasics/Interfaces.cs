using System;
namespace CSharp;

public sealed class Interfaces
{
    // below creates an interface, which is essentially a contract between the interface and the implementation class, which will inherit from the interface.
    // Visual Studio and some other IDEs will let you know to implement these methods within the implementation class.
    // a class can inherit multple interfaces to make knowing what methods will be implemented easier when making bigger systems.
    public interface IMyInterface
    {
        // written in the format of [returntype] [methodName] (params) {}
        int MyMethod(int a, int b);
    }
    public class SimpleAddition : IMyInterface
    {
        // implements the method defined in the interface.
        public int MyMethod(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }

}

