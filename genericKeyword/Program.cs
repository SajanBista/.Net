using System;

namespace Generic_delegate
{
    // 1. Generic delegate definition
    public delegate T MyGenericDelegate<T>(T parameter);

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Using generic delegate with int
            MyGenericDelegate<int> square = Square;
            Console.WriteLine("Square of 5: " + square(5));

            // 3. Using generic delegate with string
            MyGenericDelegate<string> reverse = Reverse;
            Console.WriteLine("Reverse of 'Hello': " + reverse("Hello"));
        }

        // 4. Method to return square of a number
        static int Square(int x)
        {
            return x * x;
        }

        // 5. Method to reverse a string
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray(); // Convert string to character array
            Array.Reverse(charArray);           // Reverse the array
            return new string(charArray);       // Convert back to string and return
        }
    }
}
