// See https://aka.ms/new-console-template for more information
using System;


public class Person
{
    public string Name;
    public int Age;
}

public class Program
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = a ;
        b = 20;
        Console.WriteLine(a);
        
        
        Person person1 = new Person();
        person1.Name = "Ram";
        person1.Age = 40;
        Person person2 = person1;
        person2.Name = "Test";
        Console.WriteLine(person1.Name);
        
        int num = 123;
        double doubleNum = num;
        Console.WriteLine(doubleNum);
        
        double doubleNum1 = 123.45;
        int num1 = (int)doubleNum;
        Console.WriteLine(num);
        
    }
}
