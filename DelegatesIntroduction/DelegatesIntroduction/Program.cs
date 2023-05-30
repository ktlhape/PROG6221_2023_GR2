using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesIntroduction
{
    internal class Program
    {
        public delegate void PrintDelegate(string message);
        public delegate bool VoteDelegate(int x);
        static void Main(string[] args)
        {

            // PrintDelegate del = new PrintDelegate(Print);
            PrintDelegate myPrintDelegate = Print;
            PrintDelegate myDisplayDelegate = Display;
            myPrintDelegate("Today is Tuesday");
            myDisplayDelegate("Hello World");

            //create a chained delegate
            PrintDelegate myChainedDelegate = 
                myDisplayDelegate + myPrintDelegate;

            DisplayOutput(19, CanVote);
        }
        static void Display(string text)
        {
            Console.WriteLine(text);
        }
        static void Print(string message)
        {
            Console.WriteLine("My message is: " + message);
        }

        static bool CanVote(int age)
        {
            return age >= 18;
        }
        static void DisplayOutput(int age, VoteDelegate voteFilter)
        {
            if (voteFilter(age))
            {
                Console.WriteLine("Can Vote");
            }
            else
            {
                Console.WriteLine("Cannot Vote");
            }
        }


    }
}
