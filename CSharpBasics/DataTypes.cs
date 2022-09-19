using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.Concurrent;
using System.Collections;

namespace CSharp;

public sealed class BasicDataTypes
{
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/
    // below are some methods which are available on each data type.
    private void MyMethod()
    {
        /* declaring and setting variables below */
        /* all other data types are derived off the object data type */
        // the ? when specifying the data type of a field or variable means it can be of no value otherwise known as null.
        object myProperty = null!;
        int? myInt = null;
        string myString = string.Empty;
        double myDouble = 0.0;
        decimal myDecimal = 0m; // for storing 15 decimal digits
        bool myBool = false;
        DateTime myDateTime = DateTime.Now;

        // uncommon or lower level data types.
        float myFloat = 0; // for storing 6 to 7 decimal digits
        long myLong = 0; // 64 bit signed int
        short myShort = 0; // 16 bit signed int
        char myChar = 'a';
        byte myByte = 1; // 8 bits to a byte, unsigned
        uint MyUnit = 12;
        sbyte mySByte = 8; // 8 bits to a byte, signed

        // below are some methods which can be called on a int data type.
        myInt.ToString();
        // makes the string uppercase
        myString.ToUpper();
        // makes the string lowercase
        myString.ToLower();
        // get the length of a string, and store it in a variable, which returns an integar.
        int myLengthOfString = myString.Length;
        // converts a double to a string
        myDouble.ToString();
        // converts a decimal to a string
        myDecimal.ToString();
        // converts a boolean to a string
        myBool.ToString();
        // get the type of an object, in this instance returns the type object.
        myProperty.GetType();
        // converts a float to a string.
        myFloat.ToString();
        // checks if the 
        myChar.ToString();
    }
    private int ImplicitTypes()
    {
        // below represents how to spwcify an implicit type, using the var keyword.
        var myImplicitType = 15;
        return myImplicitType;
    }

    public sealed class FrequenetlyUsedCollectionDataTypes
    {
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
        public void MyListMethod()
        {
            // make a new list of objects
            // the way I would read the below is IList Of Object, called objects and then makes an instance of a List Of objects.
            IList<object> objects = new List<object>();
            // add some values to the list, one is a string one is an integer.
            objects.Add("string value");
            objects.Add(12);
            // below, returns the list with the two values in a list, by using a for each or for loop.
            // all collections i.e arrays, lists, etc start at 0.
        }

        // ICollection interface defines methods that you can use to iterate and manipulate the array or list of objects.
        // for example you can add, remove, insert, etc value to and from the list of objects.
        // myListMethod();
        public ICollection<object> MyCollectionMethod()
        {
            ICollection<object> objects = new List<object>();
            objects.Add("string value");
            objects.Add(12);

            return objects;
        }

        // IEnumerable interface defines only one method, GetIterator.
        // this means it can used in a loop, for example: for, foreach, do while, do until.
        public IEnumerable<object> MyEnumerableListMethod()
        {
            IEnumerable<object> objects1 = new List<object>();
            // below does not work as Add method is not within the IEnumerable interface, therfore the method is not implemented in the implementation class
            // in this instance, it will List<>();
            //objects1.Add();
            return objects1;
        }

        // The below uses IList interface so you're able to use the Add, Remove, Insert, Clear, etc
        // methods that are implemented in the ArrayList implementation class.
        public void MyArrayListMethod()
        {
            IList objects = new ArrayList();
            objects.Add("myStringObject");
            objects.Remove("myStringObject");
            objects.Insert(1, "another string object.");
            objects.Clear();
        }

        // Arrays
        // I'd personally use the IList interface and List implementation class, but here it is anyway.
        public object[] Array2Dimentional()
        {
            object[] objects2D = { "something", 12, true, false };
            return objects2D;
        }
        // by specifying object as the type that the array can hold, this means we are able to hold any data type within the array.
        // the example below can hold integars and strings, etc, as they all inherit or derive from the base class of object.
        public object[,] Array3Dimentional()
        {
            object[,] objects3D = { { 1, 2 }, { "some string", "another string" } };
            return objects3D;
        }

        // this data type hold key value pairs
        public void Dictionaries()
        {
            Dictionary<object, object> MyDictionary = new Dictionary<object, object>();
            // below a guid creates a new Globaly Unique Identifier 
            Guid myGuid = Guid.NewGuid();
            MyDictionary.Add("Id", myGuid.ToString());

            foreach (var obj in MyDictionary)
            {
                Console.WriteLine(obj.Key);
                Console.WriteLine(obj.Value);
            }
        }
    }
    public sealed class OtherCollectionDataTypes
    {
        // below creates a new instance of a doubly linked list.
        public LinkedList<object> linkedList = new LinkedList<object>();

        private LinkedList<object> MyLinkedListMethod()
        {
            // few methods are implemented with this data type, allows you to create an instance of a LinkedListNode,
            // I like to think of it a bit like xml and xpath.
            // Add to the first node of the linkedlist.
            linkedList.AddFirst("MyString");
            // Add to the last node of the linkedlist.
            linkedList.AddLast(12);
            // Find the linkedlistnode that has the value entered as a parameter to the find method.
            var linkedListNode = linkedList.Find(12);
            if (linkedListNode != null)
                linkedList.AddBefore(linkedListNode, "Additonal String");
            return linkedList;
            // with a linkedlist and some other collection data types you'll have to make your own sorting algorythm. 
        }
        // Last In First Out approach when removing items. Items are added sequencially to the stack.
        private Stack<object> MyStack()
        {
            Stack<object> stack = new Stack<object>();
            stack.Push("MyString");
            stack.Peek(); // returns object at the top of the stack.
            stack.Pop(); // removes the object at the top of the stack.
            return stack;
        }
        private SortedDictionary<object, object> MySortedDictionary()
        {
            SortedDictionary<object, object> mySortedDictionary = new SortedDictionary<object, object>();
            mySortedDictionary.Add("string", 1);
            return mySortedDictionary;
        }
        private SortedSet<object> SortedSet()
        {
            SortedSet<object> sortedSet = new SortedSet<object>();
            sortedSet.Add("myString");
            sortedSet.Remove("myString");
            sortedSet.Reverse();
            sortedSet.Clear();
            return sortedSet;
        }
        private Queue<object> Queue()
        {
            // first in last out, like a stack.
            Queue<object> queue = new Queue<object>();
            queue.Peek();
            // adds an element to the end of the queue.
            queue.Enqueue("myString");
            // removes from beginning of the queue.
            queue.Dequeue();
            return queue;
        }
        private ObservableCollection<object> ObservableCollection()
        {
            ObservableCollection<object> observableCollection = new ObservableCollection<object>();
            observableCollection.Add("myString");
            observableCollection.Remove("myString");
            observableCollection.Insert(1, "Another String");

            return observableCollection;
        }
    }
}



