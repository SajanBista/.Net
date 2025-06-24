// WAP following instruction below:
// a) In the program there are 5 integer instance variables (a, b, c, d and e)
//    with value a = 10, b = 5, d = 4
// b) Now using multicast delegate chaining add a and b using Add() method and assign value to c and subtract d value from c using Sub() method 
// and assign to e and return a final value.

using System;

namespace DelegateExample
{
    // Step 1: Declare a delegate
    public delegate void MyDelegate();

    class MyClass
    {
        // Step 2: Declare instance variables
        int a = 10, b = 5, c, d = 4, e;

        // Step 3: Add method
        public void Add()
        {
            c = a + b;
            Console.WriteLine("Step 1: a + b = " + c);
        }

        // Step 4: Subtract method
        public void Sub()
        {
            e = c - d;
            Console.WriteLine("Step 2: c - d = " + e);
        }

        // Step 5: Show final result
        public void ShowResult()
        {
            Console.WriteLine("Final Result (e) = " + e);
        }

        // Step 6: Main method
        static void Main(string[] args)
        {
            // Create object of class
            MyClass obj = new MyClass();

            // Create delegate instance and add methods to it
            MyDelegate del = obj.Add;
            del += obj.Sub;

            // Invoke the delegate (this will call both methods)
            del();

            // Show final result
            obj.ShowResult();

            // Hold console window
            Console.ReadLine();
        }
    }
}
