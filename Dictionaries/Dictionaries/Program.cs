using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * [Dictionary]<keyType,valueType> [name] = 
             * new [Dictionaty]<keyType,valueType>();
             * 
             * Create a dictionary that will store student numbers
             * and their names
             */

            //Declare a dictionary
            Dictionary<string, string> students =
                new Dictionary<string, string>();
       

            //Add items to the dictionary

            students.Add("S123", "Roger");
            students.Add("S124", "Michael");
            students.Add("S125", "Jessica");
            students.Add("S126", "Lebo");
            students.Add("S127", "James");

            students["S123"] = "Kabelo";
            students["S144"] = "David";
            students["S123"] = students["S126"];

            string name = students["S127"];
            string stNum = students.ElementAt(2).Key;
            string stName = students.ElementAt(2).Value;

            //Display the elements

            foreach (KeyValuePair<string,string> st in students)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine($"{name}\n{stName}\n{stNum}");
        }
    }
}
