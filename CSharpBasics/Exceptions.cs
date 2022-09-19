using System;
namespace CSharp;

public class Exceptions
{
    public void MyMethod()
    {

        // below you can use a try block, optionally a catch block, and optinally a finally block.
        // however if you don't have a catch block, you'll need a finally block.
        try
        {
            // do something
        }
        catch (Exception ex)
        {
            // below uses the throw keyword to throw an exception, and will show an error has occoured.
            // you can also use a logger to log errors.
            throw new Exception(ex.Message, ex.InnerException);
        }
        finally
        {
            // do something, such as close a connection to a database, or manually dispose of the object.
        }

        try
        {
            // do something
        }
        finally
        {
            // do something
        }

        try
        {
            // do something
        }
        catch (Exception ex)
        {
            // do something
        }
    }
}

