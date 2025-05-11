//Abstract classes = can't make object we should access  it making derived class, means only be accessed  by inheriting in its child class

using System;

public abstract class Animal
{
    //Abstract method (must be implemented in derived class)
    public abstract void makeSound();

    public void sleep()
    {
        Console.WriteLine("Zzzzzzz!!!"); 
    }
}

public class Dog : Animal
{
    public void walk()
    {
        Console.WriteLine("dog is walking"); 
    }

   
    public override void makeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

class Program 
{
    static void Main(string[] args)
    {
        // Create a dog object
        Dog dog = new Dog();
        
        // Call methods
        dog.makeSound();
        dog.walk();
        dog.sleep();
    }
}
//creates layer of abstraction
