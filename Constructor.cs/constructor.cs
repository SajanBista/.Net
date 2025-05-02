using System;

namespace Constructor.cs
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("hello");

        }
        ~Program()
        {
            Console.WriteLine("Destructor called");


        }
        static void Main(String[] args)
        {
            DefaultConstructorClass obj = new DefaultConstructorClass();
            Console.WriteLine("Value of x: " + obj.a);


        }
    }


    class DefaultConstructorClass
    {
         public readonly int a;
        public  DefaultConstructorClass()
        {
            a= 1;

        }
    }
}


