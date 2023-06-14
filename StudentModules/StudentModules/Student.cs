using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentModules
{
    public class Student
    {
        public string StNumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string MethodOfStudy { get; set; }

        public static List<Student> Students { get; set; } = new List<Student>();
        public Student() { }
        public Student(string stNumber, string firstname,
            string lastname, int age, string methodOfStudy)
        {
            StNumber = stNumber;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            MethodOfStudy = methodOfStudy;
        }

        public override string ToString()
        {
            return $"({StNumber}) : {Firstname} {Lastname} - {Age}\n" +
                $"Method of Study: {MethodOfStudy}\n";
        }
        public static string AllStudents()
        {
            string strDetails = "";

            foreach (Student st in Students)
            {
                strDetails += st.ToString() + "\n";
            }

            return strDetails;
        }


        /*Create a method that will return a student
         of the matching student number. Pass the student
        number as the parameter*/

        public static Student GetStudent(string stNum)
        {
            Student stObject = new Student();
            //Logic
            foreach (Student st in Students)
            {
                if (stNum.Equals(st.StNumber))
                {
                    stObject = st;
                }
            }
            return stObject;

        }

    }
}
