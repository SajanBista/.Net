using System;

namespace Func_Delegate
{
    
    public delegate TResult Func<TResult>();
    public delegate TResult Func<T, TResult>(T arg);
    public delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);

    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> square = Square;
            int result = square(5);
            Console.WriteLine(result);


            Func<int, int, int> multiply = Multiply;
            int product = multiply(4, 5);
            Console.WriteLine(product);

            Func<string> greet = Greet;
            Console.WriteLine(greet());

            Func<string> name = Name;
            Console.WriteLine(name());
        }

        static int Square(int x)
        {
            return x * x;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static string Greet()
        {
            return "Hello Manoj";
        }
        static string Name()
        {
            return "I am manoj Chor";
        }
    }
}
