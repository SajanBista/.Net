// using System;

// namespace Constructor.cs
// {
//     public class Program
//     {
//         public Program()
//         {
//             Console.WriteLine("hello");

//         }
//         ~Program()
//         {
//             Console.WriteLine("Destructor called");


//         }
//         static void Main(String[] args)
//         {
//             DefaultConstructorClass obj = new DefaultConstructorClass();
//             Console.WriteLine("Value of x: " + obj.a);


//         }
//     }


//     class DefaultConstructorClass
//     {
//         public readonly int a;
//         public DefaultConstructorClass()
//         {
//             a = 1;

//         }
//     }
// }
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
			InstanceConstructorExample obj1 = new InstanceConstructorExample(5);
			InstanceConstructorExample obj2 = new InstanceConstructorExample(100);
			
			Console.WriteLine("Value of x in obj1:"+ obj1.x);
			Console.WriteLine("Value of x in obj2:"+ obj2.x);
			
			


        }
    }


    class DefaultConstructorClass
    {
         public readonly int a;
        public  DefaultConstructorClass()
        {
            a = 12;

        }
	}
	public class InstanceConstructorExample
	{
		public int x;
		
		public InstanceConstructorExample(int value)
		{
			x = value;
		}
	}
		
}





