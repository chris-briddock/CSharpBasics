using System;
namespace CSharp;

public class ClassesStructsRecords
{
    private string last;
    private string first;

    // below is a constructor, a void method (no return type, whose name is the same as the types name, which is called when the class is instantiated.
    // it can have a few access modifiers such as static, private and public.
    public ClassesStructsRecords(string lastName, string firstName)
    {
        last = lastName;
        first = firstName;   
    }
    // 
    /* public type or class, can be instantiated and inherited from internal or external assembly. */
    public class MyPublicClass
    {
        int MyInt = 0;
    }

    /* Only accessible within the same class */
    private class PrivateClass
    {
        int MyInt = 0;
    }
    /* protected internal class and its members, can be accessed by a class that inherits this class, 
     * whether it's internally or externally or instantiated within the internal assembly. 
     * but cannot be accessed by being instantiated in an external assembly.
     */
    protected internal class InternalProtectedIntClass
    {
        int ExampleInt = 0;
    }
    /* Class and its members can be accessed within the same class or inherited from within an internal or external assembly.*/
    protected class ProtectedClass
    {
        int ExampleInt = 0;
    }
    /* Inherited or instantiated from within the same assembly only */
    internal class InternalClass
    {
        int MyInternalInt = 0;
    }
    /* Inherited from only within the same assembly */
    protected private class ProtectedPrivateClass
    {
        protected int ProtectedInt = 0;
    }
    /* Abstract allows for incomplete classes which must be inherited from. */
    public abstract class AbstractClass
    {
        /* virtual and abstract property and method modifiers (not variables/fields), allows the use of the override keyword when the class has been inherited/derived from. */
        public virtual object MyProperty { get; set; } = null!;
        /* Incomplete method definition */
        public abstract void MyMethod();
    }
    /* Sealed classes disable inheritance 
     * Below the AbstractClass has been inherited from and so you can override the below property and method.
     */
    public sealed class SealedClass : AbstractClass
    {
        // below the base keyword allows the inherited abstract class constructor to be accessible within the sealed class constructor.
        public SealedClass() : base()
        {

        }
        // MyProperty is not null now, it is now a number.
        public override object MyProperty { get; set; } = string.Empty!;
        public override void MyMethod()
        {
            Console.WriteLine("MyMethod has been overridden.");
        }
    }
    /* Static class members can be accessed from anywhere within the assembly or external assembly, cannot be inherited from or instantiated. */
    public static class MyStaticClass
    {
        public static int MethodOne()
        {
            int MyIntOne = 1;
            int MyIntTwo = 2;

            int Result = MyIntOne + MyIntTwo;

            return Result;
        }

    }
    /* Below calls the static method, and set the below variable or field to the result of the method being called. 3 */
    int CallStaticMethod = MyStaticClass.MethodOne();

    // below makes use of this:- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-forgiving
    // by using the partial keyword, allows you to extend the partial class with another partial class, just use the same class name somewhere different in a project.
    // For example using a partial class in a big project that multiple devs are working on. Similar for a method too.
    public partial class MyPartialClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }

    // Below is a struct example, essentially a lightweight version of class. This is because they are value types, where classes are reference types.
    // Implicitly sealed by default, and cannot have a default constructor or destructor. In simple terms, less memory slightly, and a little better peformance.
    public struct MyStruct
    {
        public int AddTwoNumbers(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }

    // Used to specify if it's a reference type, not a value type like a class. Can be used for immutable (not changable) data.
    public sealed record MyRecord
    {
        public int MyInt { get; set; } = 0;
    }
    // below is a record class, can also be a struct.
    public sealed record class MyRecordClass
    {
        public void MyMethod()
        {
            // do something..
        }
    }

    public sealed class MyEntity
    {
        // below covers properties in a class, can also be a struct
        // getters and setters, as the same implies, get will get the current value of the property, whilst set assigns it a value.
        // you can also perform some logic whilst getting or setting the value of a property.

        public string _url = string.Empty;
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string URL
        {
            get => _url;
            set
            {
                // logic here
            }
        }
    }

    // below is an example of a finalizer.
    //~ClassesStructsRecords()
    //{
    //    // clean up resources here.
    //    //GC.Collect();
    //}
    // below is an example with the alternate syntax, this is used through out in c# on methods and properties.
    ~ClassesStructsRecords() => Console.WriteLine("Finalizer, which was formally called a destructor is now being called.");

}

