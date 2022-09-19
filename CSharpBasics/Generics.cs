using System;
namespace CSharp;

public class Generics
{
    // below specifies a generic interface, and explicitly specifies that T is a class object.
    // Generics let you use any type
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
    public interface IGenericRepo<T> where T : class
    {
        T Get();
        T Put();
        T Post();
        T Delete();
    }
    // below is a generic method.
    public static void MyMethod<T>()
    {
        T Temp;
    }
}

