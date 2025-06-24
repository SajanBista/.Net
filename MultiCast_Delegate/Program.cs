using System;

namespace Multicast_Delegate
{

    // Step 1: Declare the delegate
    public delegate void RemoteControl();

    public class Program
    {
        // Step 2: Define the methods
        public static void TurnOnTV()
        {
            Console.WriteLine("TV is ON");
        }

        public static void TurnOnLight()
        {
            Console.WriteLine("Light is ON");
        }

        public static void TurnOnFan()
        {
            Console.WriteLine("Fan is ON");
        }

        // Step 3: Use multicast delegate
        public static void Main()
        {
            RemoteControl remote = TurnOnTV;   // Add TV
            remote += TurnOnLight;              // Add Light
            remote += TurnOnFan;               // Add Fan

            Console.WriteLine(" Turning everything ON");
            remote(); // Calls all three methods

            remote -= TurnOnLight;              // Remove Light

            Console.WriteLine("Turning ON without Light");
            remote(); // Only TV and Fan
        }
    }
}