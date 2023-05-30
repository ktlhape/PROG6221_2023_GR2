using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Create a dictionary to store departments and the list
             * of employees working on those departments
             */

            Dictionary<string, List<string>> empDepartments =
                new Dictionary<string, List<string>>();

            empDepartments.Add("IT", new List<string>() { "Kabelo", "James", "David" });
            empDepartments.Add("HR", new List<string>() { "Jessica", "Lerato" });
            empDepartments.Add("FINANCE", new List<string>() { "Caroline", "John" });

            //Console.WriteLine("DEPARTMENTS");
            //foreach (string dep in empDepartments.Keys)
            //{
            //    Console.WriteLine(dep);
            //}

            foreach (string department in empDepartments.Keys)
            {

                Console.Write(department);
                //Console.WriteLine("-----------------");
                foreach (string employee in empDepartments[department])
                {
                    Console.WriteLine($"\t{employee}");
                }
            }

       


        }
    }
}
