using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserDeatails
{
    internal class Program
    {
        //Global declaration
        static string name, surname, idNumber;
        static int age;
        static double height;
        static char gender;
        static void Main(string[] args)
        {
            
            //Assign
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter id number: ");
            idNumber = Console.ReadLine();
            Console.Write("Enter gender (M, F, O) ");
            gender = Convert.ToChar(Console.ReadLine());

            //display
            Console.WriteLine("=========before changes============");
            DisplayDetails();

            //using methods from the string class
            name = name.ToUpper();
            name = name.Replace("A", "i");
            name = name.Insert(0,"#");

            Console.WriteLine("=========after changes============");
            DisplayDetails();
            Console.WriteLine("ID Number Length: " + GetIDLength());

            Console.Read();
        }

        static void DisplayDetails()
        {
            string genderDesc = GetGender(gender);
            Console.WriteLine($"Name: {name}\n Surname: {surname}\n" +
                $"Age: {age}\n Height: {height}\n ID: {idNumber}\n " +
                $"Gender: {genderDesc}");
        }

        static int GetIDLength()
        {
            return idNumber.Length;
        }

        static string GetGender(char gender)
        {
            string genderDesc = "Unknown";

            if (gender == 'm' || gender == 'M')
            {
                genderDesc = "Male";
            }
            else if(gender == 'f' || gender == 'F')
            {
                genderDesc = "Female";
            }else if (gender == 'O' || gender == 'o')
            {
                genderDesc = "Other";
            }
            else
            {
                genderDesc = "Undefined";
            }

            return genderDesc;
        } 
    }
}
