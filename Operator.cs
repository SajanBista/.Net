// See https://aka.ms/new-console-template for more information
//Operators === checks equal or not and also gives data type.

/*
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b =5;
        int c =a+b;
        int d = a-b;
        int g = a*b;
        int e = a/b;
        int f = b%a;
        //Arithmetical operatior

        Console.WriteLine($"the addition of a and b is {c}",c);
        Console.WriteLine($"the subtraction of a and b is {d}",d);
        Console.WriteLine($"the division of a and b is {g}",g);
        Console.WriteLine($"the multiplication of a and b is {e}",e);
        Console.WriteLine($"the modulas of a and b is {f}",f);

        //logical operator
        if(a==10 && b==5)
        {
            Console.WriteLine("it is true statement");
        }
        else{
             Console.WriteLine("it is false statement");
        }


        // if(a==10 && b==5)
        // {
        //     Console.WriteLine("it is true");
        // }
        // else{
        //     return false;
        // }
        Console.WriteLine("Bitwise operator");
        if((a&b) == (b&c)){
            Console.WriteLine("it is true statement");
        }
        else{
            Console.WriteLine("it is false statement");
        }
    }
}
        
        */

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("This is the use of bitwise operator");

        int a = 5;//0101
        int b = 3;//0011
        int result = a & b;// 0001 in binary after gate 
        Console.WriteLine($"This is the final result of operator &:\t{result}", result);// result is 1

        int result1 = a | b;// 0111
        Console.WriteLine($"This is the final result of operator |:\t{result1}", result1);// 111 = 7

        int result2 = a^b;//110
        Console.WriteLine($"This is the final result of operator ^ :\t{result2}", result1);///110 = 6
        //Homework remaining ~, >>>, <<<







    }
}
