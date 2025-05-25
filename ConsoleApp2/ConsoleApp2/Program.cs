using System;

namespace MethodOverriding
{
    public class Animal
    {
        public virtual void speak() // base class method
        {
            Console.WriteLine("Animal speaks");
        }
    }

    public class Dog : Animal
    {
        public override void speak() // overriding the base class method
        {
            Console.WriteLine("Dog is speaking now");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Animal myanimal = new Animal();  // Base class object
            myanimal.speak();                // Output: Animal speaks

            Animal mydog = new Dog();        // Base class reference to derived class object
            mydog.speak();                   // Output: Dog is speaking now (runtime polymorphism)

            Dog mydog2 = new Dog();          // Derived class object
            mydog2.speak();                  // Output: Dog is speaking now
        }
    }
}
