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

        public static List<Student> Students { get; set; } = new List<Student>() 
        { 
            new Student("ST123","Michael","Smith",23,"Full-time"),
            new Student("ST124","Jessica","Jones",24,"Full-time"),
            new Student("ST125","Kabelo","Tlhape",23,"Full-time"),
            new Student("ST126","Thabo","Mokoena",21,"Full-time"),
            new Student("ST127","Caroline","Smith",25,"Full-time"),
            new Student("ST128","Roger","Federer",22,"Full-time"),
            new Student("ST129","Jonathan","Jones",26,"Full-time")
        };
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
            #region
            //Student stObject = new Student();
            //Logic
            //foreach (Student st in Students)
            //{
            //    if (stNum.Equals(st.StNumber))
            //    {
            //        stObject = st;
            //    }
            //}
            #endregion
            Student stObject = Students.Find(st => st.StNumber.Equals(stNum));
            return stObject;
        }

        /*Create a method that will return a list of students
       of the matching lastname. Pass the lastname as 
        the parameter*/

        public static List<Student> GetStudentByLastname(string lastname)
        {

            #region
            //List<Student> stList = new List<Student>();
            //foreach (Student st in Students)
            //{
            //    if (st.Lastname.Equals(lastname))
            //    {
            //        stList.Add(st);
            //    }
            //}
            #endregion
            List<Student> stList = Students.Where(st => st.Lastname.Equals(lastname)).ToList();
            return stList;
        }

        public static string GetStudentsData(List<Student> stList)
        {
            string strDetails = "";

            foreach (Student st in stList)
            {
                strDetails += st.ToString() + "\n";
            }

            return strDetails;
        }


    }
}
