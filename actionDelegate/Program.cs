using System;

namespace Action_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> greet = Greet;
            greet("World");

            Action<int, int> addAndPrint = AddAndPrint;
            addAndPrint(5, 10);
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static void AddAndPrint(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }
    }
}
