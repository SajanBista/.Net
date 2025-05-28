using System;
namespace Static_Class
{
    class Program
    {
        static void Main()
        {
            int sum = MathUtilities.Add(5, 10);
            Console.WriteLine($"The sum is: {sum}");


            Console.WriteLine($"Application Name: {Configuration.ApplicationName}");
            Console.WriteLine($"Max Users: {Configuration.MaxUsers}");

            string exampleString = "Hello, World!";
            string reversed = exampleString.Reverse();
            Console.WriteLine($"Reversed string: {reversed}");
        }
    }
    //Utility class
    public static class MathUtilities
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
    //Configuration class
    public static class Configuration
    {
        public static string ApplicationName { get; private set; }
        public static int MaxUsers { get; private set; }
        //static constructor
        static Configuration()
        {
            ApplicationName = "My Application";
            MaxUsers = 10;
        }
    }
    //Extension method
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}