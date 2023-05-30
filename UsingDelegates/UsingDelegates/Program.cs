using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates
{
    internal class Program
    {
        public delegate bool NameFilter(string name, string text);
        static void Main(string[] args)
        {
            //Create a list of students
            List<string> students = new List<string>() {
            "Mike","Michael","John","Kabelo","James","Roger",
            "Jessica","Carol"
            };

            DisplayNames(students,"o",IsContains);
        }
        static void DisplayNames(List<string> stList, string text, NameFilter filter)
        {
            foreach (string name in stList)
            {
                if (filter(name,text))
                {
                    Console.WriteLine(name);
                }
            }
        }
        static bool IsStartWith(string name, string text)
        {
            return name.StartsWith(text);
        }
        static bool IsEndWith(string name, string text)
        {
            return name.EndsWith(text);
        }
        static bool IsContains(string name, string text)
        {
            return name.Contains(text);
        }
    }
}
