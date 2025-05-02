using System;
public class Program
{
    public static void Main(string[] args)
    {
        string s = "K xa ?";

        Console.WriteLine(s.ToUpper());
        Console.WriteLine(s.ToLower());

        string str1 = "Manoj";
        string str2 = "ghar kata?";

        //string result = str1 + str2 ;

        string result = string.Concat(str1+ " " +str2);

        Console.WriteLine(result);

        int a = 10;

        Console.WriteLine("Hello {0} {1} {2}", a, a, a);
    }



}
