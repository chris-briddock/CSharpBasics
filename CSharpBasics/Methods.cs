using System;
namespace CSharp;

public class Methods
{
    // delcare a method, there are several access modifiers you're able to use, along with return data types.
    // I'm using void in this example to show it does return a value.
    public void MyMethod()
    {
        // do something..
    }
    // below is a method overload, this kind of method will have the same name can be a different return type, but different parameters.
    public static int MyMethod(int a, int b)
    {
        int result = a + b;
        return result;  
    }

}
// below is an extension method, in this example you can check if a number is greater than another.
public static class IntExtensions
{
    public static bool IsGreaterThan(this int i, int value)
    {
        return i > value;
    }
    // this method is an example of how you can now call that extension method.
    public static void MyIntMethod()
    {
        int myInt = 0;
        myInt.IsGreaterThan(0);
    }
}


