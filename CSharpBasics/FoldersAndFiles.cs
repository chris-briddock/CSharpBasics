using System.IO;
namespace CSharp;

public class FilesAndFolders
{
   public void MyMethod()
    {
        // below are some example of using the System.IO namespace.
        
        // allows you to create a folder or directory.
        System.IO.Directory.CreateDirectory("mydirectory");
        Directory.Delete("pathHere");
        Directory.Move("source", "destination");
        // gets all directories within a directory
        Directory.GetDirectories("pathHere");
        // allows you to create a file.
        File.Create("pathHere.idx");
        // reads all bytes of a binary file.
        File.ReadAllBytes("pathHere");
        // creates a text based file.
        File.CreateText("pathHere");
        // move a file
        File.Move("sourceFileName", "destinationFileName");
        // encrypt a file 
        File.Encrypt("pathHere");
        // decrypt a file
        File.Decrypt("pathHere");
        var bytes = new byte[10];
        // writes a byte array to a file
        File.WriteAllBytes("pathHere", bytes); 
        // System.IO can also query the registry in Windows.

    }
}

