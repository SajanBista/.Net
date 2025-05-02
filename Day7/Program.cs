Using System;
using System.Collections.Generic;

class ControlStatement
{
    static void Main(){
        Console.WriteLine("Starting main method");

        Console.WriteLine("\nUsing goto statement");
        UseGoto();
        Console.WriteLine("\nUsing break statement");
        UseBreak();
        Console.WriteLine("\nUsing return statement");
        UseReturn();
        Console.WriteLine("\nUsing Main statement");

        List<string>list = new List<string>();
        list.Add("One");
        list.Add("Two");
        list.Add("Three");
        list.Add("Four");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void UseGoto(){
        int x =5;
        if(x == 5)
        {
            goto skip; //Transfer control to the lebeled statement
        }
        Console.WriteLine("this will not be printed because x ==5");
    skip:
        Console.WriteLine("Exited the control block using");
    }

    static void UseBreak()
    {
        int y = 5;
        switch (y)
        {
            case 1:
                Console.WriteLine("y is 1");
                break;
            case 5:
                Console.WriteLine("y  is 5");
                break;//Exit the switch block
            default:
                Console.WriteLine("y is not 1 or 5");
                break;
        }
        Console.WriteLine("Exited the switch block using break");
    }
    static void UseReturn()
    {
        int z = 5;
        if(z==5)
        {
            return; //Exit the method
        }
        Console.WriteLine("This will not be printed because z ==5");
        Console.WriteLine("This line will never be reached if z == 5");
    
}
}