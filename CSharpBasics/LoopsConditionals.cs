namespace CSharp;

public class LoopsConditionals
{
    // creates a new list instance of objects within the list.
    private List<object> objects = new List<object>();

    public void Loops()
    {
        // below iterates over a list of objects starting from 0, 1,2 etc.
        // Value 0 = "string value"
        // Value 1 = 12
        for (int i = 0; i < objects.Count; i++)
        {
            // uses the [] syntax to access the index of an array. If for example you had 3 objects in a list, you could use [j] to specify which item in the list,
            // where j is equal to a number.
            Console.WriteLine(objects[i]);
        }
        foreach (object obj in objects)
        {
            Console.WriteLine(obj);
        }
        int j = 0;
        do
        {
            Console.WriteLine(objects[j]);
            j++;
        }
        while (j < objects.Count);

        // try to avoid infinite loops like the one below.

        while(true)
        {
            Console.WriteLine("Infinite Loop!");
        }
    }
    public void Conditionals()
    {
        int myInt = 0;

        // simple if else if else statement.
        // you can just use if, or an if else.
        if (myInt >= 0)
        {
            // do something..
        }
        else if (myInt > 0)
        {
            // do something
        }
        else
        {
            // if condition is not met, then do this.
        }
        // alternate syntax for an if statement.
        if (myInt >= 0)
            Console.WriteLine("This will output a string");
            Console.WriteLine("Something else");

        switch (myInt)
        {
            case 0:
              Console.WriteLine("MyInt is" + myInt);
                break;
            default:
                // default is kind of like an else statement, if none of the critera matches then this will be executed.
                break;
        }
        switch (myInt)
        {
            case object _ when myInt >= 0 && myInt <= 0:
                Console.WriteLine("This allows for operators to be used in a switch case statement, you can also check for more than one condition to be met.");
                break;
            default:
                break;
        }
        // below is the ternary operator, sort of like an if else statement where a condition is met.
        var myResult = myInt > 0 ? "myInt is more than 0" : "myInt is less than or equal to 0";

    }
}

