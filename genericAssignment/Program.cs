// In C#, a generic allows you to define a class, method, or delegate with a placeholder for the data 
// type, so you can use it with any type (like int, float, etc.) without repeating the same code.

using System;

namespace GenericDemo
{
    public class Calculator
    {
        // Generic Add
        public T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }

        // Generic Subtract
        public T Subtract<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }

        // Generic Multiply
        public T Multiply<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int a = 4, b = 5;
            int c = calc.Add(a, b);         // c = 4 + 5 = 9
            Console.WriteLine("c = " + c);

            int d = 5;
            int e = calc.Subtract(c, d);    // e = 9 - 5 = 4
            Console.WriteLine("e = " + e);

            int f = 2;
            int g = calc.Multiply(e, f);    // g = 4 * 2 = 8
            Console.WriteLine("g = " + g);
        }
    }
}
