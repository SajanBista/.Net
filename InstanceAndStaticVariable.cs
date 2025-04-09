using System;

namespace Day10{
    public class Test
    {
        public int a=10;

        public static int b=20;

        public void TestMethod(){
            Console.WriteLine("TestMethos");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Test t= new Test();
            int a = Test.b;
            int b = t.a;

            Console.WriteLine($"a:{a}");
            Console.WriteLine($"{b}");

        }
    }
}
