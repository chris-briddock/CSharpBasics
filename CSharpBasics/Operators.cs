namespace CSharp;

public sealed class Operators
{
    // specifying void means there is no return type.
    // For example you could specify a method as per the below:-
    // and this would return an integar value, which you could store in a variable.
    //public int MyIntMethod()
    //{
    //    int MyInt = 1;
    //    return MyInt;
    //}
    public void MathematicalOperators()
    {
        int a = 2;
        int b = 2;
        int result = 0;

        result = a + b; // addition
        result = a - b; // subtract
        result = a * b; // multiplication
        result = a / b; // divide
        result = a % b; // modulous (remainder)
        result++; // increments result by one
        result--; // decrements result by one

        // there are a few more, but these are most common.
    }
    public void ComparisonOperators()
    {
        // notice how most of the time variables should be declared at the top.
        // there are a few exceptions to this.
        // the equals sign here is an assignment operator, as in, it will set the value to the variable.
        // in this example myString is equal to Sample Text.
        string myString = "Sample Text";
        string myOtherString = "Sample Text";
        int myInt = 2;
        int myOtherInt = 2;
        bool myBool = true;

        // below checks if one value is equal to another.
        // this returns true or false
        if (myString == myOtherString)
        {
            // do something..
        }
        // below checks if one value is not equal to another.
        // this returns true or false
        if (myString != myOtherString)
        {
            // do something..
        }
        //below checks if one number is greater than another number
        if (myInt > myOtherInt)
        {
            // do something..
        }
        // below checks if one number is greater than or equal to another number
        if (myInt >= myOtherInt)
        {
            // do something..
        }
        // below checks if one number is lower than another number
        if (myInt < myOtherInt)
        {
            // do something..
        }
        if (myInt <= myOtherInt)
        {
            //do something..
        }
        // below checks if both values are equal to another value, by using the && operator.
        if (myInt > 2 && myOtherInt > 2)
        {
            // do something..
        }
        // below checks if either variable is more than 2.
        // would the code inside the if statement execute?
        if (myInt > 2 || myOtherInt > 2 )
        {
            // do something..
        }

        // below checks if the variable is false, in this instance it is true, so it expects false.
        // This is the not operator.
        if (!myBool)
        {
            // do something
        }

    }

}

