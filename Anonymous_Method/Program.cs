using System;

namespace Anonymous_Method
{
    public class Program
    {
        public delegate void Bestie(string name);
        //Main method
        static void Main(string[] args)
        {
            //An anonymous method with one parameter
            Bestie bestie = delegate (string name)
            {
                Console.WriteLine("My best friend is : {0}", name);
            };

            bestie("Ram Shrestha");
        }
    }
}