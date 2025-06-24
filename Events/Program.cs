// using System;

// namespace Event_handling1
// {

//     public delegate void SimpleEventHandler();

//     public class Publisher
//     {
//         public event SimpleEventHandler Event1;


//         public void RaiseEvent()
//         {
//             Console.WriteLine("Publisher is rising an event");
//             Event1?.Invoke();
//         }
//     }

//     public class Subscriber
//     {
//         public void OnEvent()
//         {
//             Console.WriteLine(" Suscriber received the event");

//         }
//     }
//     class Program
//     {
//         static void Main()
//         {
//             Publisher publisher = new Publisher();

//             Subscriber subscriber = new Suscriber();

//             publisher.Event1 += subscriber.OnEvent;

//             publisher RaiseEvent();
//         }
//     }
// }

using System;

namespace Event_handling1
{
    public delegate void SimpleEventHandler();

    public class Publisher
    {
        public event SimpleEventHandler Event1;

        public void RaiseEvent()
        {
            Console.WriteLine("Publisher is raising an event");
            Event1?.Invoke();  /// Safe: won't crash if no one subscribed
        }
    }

    public class Subscriber
    {
        public void OnEvent()
        {
            Console.WriteLine("Subscriber received the event");
        }
    }

    class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            // Subscribing the subscriber's method to the event
            publisher.Event1 += subscriber.OnEvent;

            // Raising the event
            publisher.RaiseEvent();
        }
    }
}
