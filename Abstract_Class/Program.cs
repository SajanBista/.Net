// using System;

// namespace TypesOFClass
// {
//      public abstract class Animal
//     {
//         //public abstract void MakeSound();


//         public void Sleep()
//         {
//             Console.WriteLine("Zzzz...");
//         }
//     }

//     public class Dog : Animal
//     {
//         public void Walk()
//         {
//             Console.WriteLine("Dog is walking");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //Console.WriteLine("Hello World!");
//             Dog myDog = new Dog();
//             myDog.Walk();
//             myDog.Sleep();
//         }
//     }
// }

using System;
namespace Abstract_Class_and_Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Sleep();

            Car car = new Car();
            car.Move();
        }
    }
    public abstract class Animal
    {
        public abstract void MakeSound();
        public void Sleep()
        {
            Console.WriteLine("sleeping...");
        }
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("bark!");
        }
    }
    public interface IMovable
    {
        void Move();
        void Stop();

        int Speed { get; set; }
    }
   
    public class Car : IMovable
    {
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}