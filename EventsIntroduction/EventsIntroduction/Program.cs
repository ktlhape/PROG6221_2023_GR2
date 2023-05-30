using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsIntroduction
{
    internal class Program
    {
        /*Create a delegate that can reference the 
         PrintMessage method*/
        public delegate void PrintDelegate(string text);
        //Event
        public static event PrintDelegate PrintEvent;
        static void Main(string[] args)
        {
            PrintMessage("Hello World");
            //Using a method
            //using a delegate
            PrintDelegate print = PrintMessage; 
            print("Hello World");

            //using an event
            //Subscribe to an event
            PrintEvent += Program_PrintEvent;
            PrintEvent += PrintMessage;

            //Unsubscribe from an event
            PrintEvent -= PrintMessage;

        }

        private static void Program_PrintEvent(string text)
        {
            throw new NotImplementedException();
        }

        static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
