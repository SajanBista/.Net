// See https://aka.ms/new-console-template for more information
using System;
public class Program
{
    public static void Main(string[] args)
    {
        // string s = "K xa ?";

        // Console.WriteLine(s.ToUpper());
        // Console.WriteLine(s.ToLower());

        // string str1 = "Manoj";
        // string str2 = "ghar kata?";

        // //string result = str1 + str2 ;

        // string result = string.Concat(str1+ " " +str2);

        // Console.WriteLine(result);


        // //Composite formatting 
        // int a = 10;

        // Console.WriteLine("Hello {0} {1} {2}", a, a, a);


        // string name ="Sangam";
        // string define = "tmi chor ho😆";
        // Console.WriteLine("mula s{0} {1}", name, define);

        // Console.WriteLine("HELLO {1} {0} {2}", "Ram", a, 9);

        //string interopolation
        // string name = "sangam ";
        // int age = 12;
        // string message = $"My name is {name} and I am {age} years old";
        // Console.WriteLine(message);

        //
        // string interpolation using for loop

        // string name = "sangam 😆😆 ";
        // for(int i = 0; i <5; i++)
        // {
        //     Console.WriteLine($"this is {i} and {name}",i,name);
        // }

        Console.WriteLine("enter your name");
        string name = Console.ReadLine();

        Console.WriteLine("enter your age");
        string age = Console.ReadLine();

        string message=($"My name is {name} and i am {age} year old");
        Console.WriteLine(message);
        



    }



}

