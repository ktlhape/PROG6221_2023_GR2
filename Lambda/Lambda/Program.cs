using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        public delegate void DisplayDelegate();
        public delegate void MessageDelegate(string msg);
        static void Main(string[] args)
        {
            #region
            /*
             1. Expression lambda
            (input parameters) => [expression]

            2. Statement lambda
            (input parameters) => {
                statements...
            };
             */
            #endregion
            Display();


            DisplayDelegate del = delegate()
            {
                Console.WriteLine("Hello World");
            };

            MessageDelegate msgDel = delegate (string message)
            {
                Console.WriteLine(message);
            };

            //using lambda : Statement
            DisplayDelegate del2 = () =>
            {
                Console.WriteLine("Hello World");
            };

            MessageDelegate msgDel2 = (msg) =>
            {
                Console.WriteLine(msg);
            };

            //using lambda : Expression
            DisplayDelegate del3 = () => Console.WriteLine("Hello World");
            MessageDelegate msgDel3 = (x) => Console.WriteLine(x);



            del();
            msgDel("Welcome to PROG2A");
        }

        
        static void Display()
        {
            Console.WriteLine("Hello World");

        }
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

      
    }
}
