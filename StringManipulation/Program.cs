using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
       static string idNumber;
        static void Main(string[] args)
        {
            string fullName, name, surname;
            int index;

            Console.Write("Enter fullname: ");
            fullName = Console.ReadLine();
            Console.Write("Enter ID Number: ");
            idNumber = Console.ReadLine();

            index = fullName.IndexOf(" ");
            name = fullName.Substring(0, index);
            surname = fullName.Substring(index + 1);

            Console.WriteLine("==========OUTPUT===========");
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Surname :" + surname);
            Console.WriteLine($"DOB: {GetDay()} {GetMonth()} {GetYear()}");
            Console.WriteLine("Gender :" + GetGender());
        }

       static int GetDay()
        {

            return Convert.ToInt32(idNumber.Substring(4, 2));
        }
        static string GetMonth()
        {
            string monthDesc = "None";
            int month = Convert.ToInt32(idNumber.Substring(2, 2));

            if (month == 1)
            { monthDesc = "JAN"; }
            else if (month == 2) { monthDesc = "FEB"; }
            else if (month == 3) { monthDesc = "MAR"; }
            else if (month == 4) { monthDesc = "APR"; }
            else if (month == 5) { monthDesc = "MAY"; }
            else if (month == 6) { monthDesc = "JUN"; }
            else if (month == 7) { monthDesc = "JUL"; }
            else if (month == 8) { monthDesc = "AUG"; }
            else if (month == 9) { monthDesc = "SEP"; }
            else if (month == 10) { monthDesc = "OCT"; }
            else if (month == 11) { monthDesc = "NOV"; }
            else if (month == 12) { monthDesc = "DEC"; }

            return monthDesc;
        }

        static string GetYear()
        {
            string strPrefix = "19";
            int year = Convert.ToInt32(idNumber.Substring(0, 2));

            if (year < 23)
            {
                strPrefix = "20";
            }
            string fullYear = strPrefix + year;

            return fullYear;
        }

        static string GetGender()
        {
            string gender;
            int numGender = Convert.ToInt32(idNumber.Substring(6,1));
            if (numGender >= 5)
            {
                gender = "MALE";
            }
            else{ gender = "FEMALE"; }

            return gender;
        }
    }
}
