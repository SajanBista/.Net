// using System;
// namespace Delegates
// {
//     //define a delegate
//     public delegate void Operation(string message);

//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             Myclass obj = new Myclass();

//             Operation operation = new Operation(obj.TestFunc);
//             operation("Sajan is the father of ankit");

//             Operation operation1 = new Operation(PrintMessage);
//             operation1("Helloworld");
//         }

//         public static void PrintMessage(string message)
//         {
//             Console.WriteLine(message);

//         }
//     }
//     public class Myclass
//     {
//         public void TestFunc(string message)
//         {
//             Console.WriteLine(message);
//         }
//     }
//     //delegate homework

// }

using System;

namespace Delegates
{
    // Define a delegate that takes a string parameter
    public delegate void Operation(string message);

    // Define another delegate that adds two numbers and returns int
    public delegate int AddOperation(int a, int b);

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create object of Myclass
            Myclass obj = new Myclass();

            // Delegate pointing to instance method
            Operation operation = new Operation(obj.TestFunc);
            operation("Sajan is the father of Ankit");

            // Delegate pointing to static method
            Operation operation1 = new Operation(PrintMessage);
            operation1("Hello World");

            // Using delegate for add method
            AddOperation addDelegate = new AddOperation(Add);
            int result = addDelegate(5, 7); // Calling Add(5, 7) via delegate
            Console.WriteLine("Addition Result: " + result);
        }

        // Static method to print a message
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Static method to add two numbers
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Myclass
    {
        // Instance method to print a message
        public void TestFunc(string message)
        {
            Console.WriteLine(message);
        }
    }
}
