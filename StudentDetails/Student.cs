using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    internal class Student
    {
        public string StudentID { get; set; }//Automatic property
        public string Name { get; set; }
        public string Surname { get; set; }
        private int numOfModules;

        public int NumOfModules
        {
            get { return numOfModules; }
            set { numOfModules = value; }
        }
        public string[] Modules { get; set; }

        public Student() //Default constructor
        {
            this.StudentID = "0000";
            this.Name = "None";
            this.Surname = "None";
            this.NumOfModules = 0;
        }
        public Student(string id, string theName, 
            string theSurname, int numModules)
        {
            this.StudentID = id;
            this.Name = theName;
            this.Surname = theSurname;
            this.NumOfModules = numModules;
            this.Modules = new string[numModules];
        }

        public void Display()
        {
            Console.WriteLine($"ID: {StudentID}\n" +
                $"Name: {Name} {Surname}\n" +
                $"Number of Modules: {NumOfModules}");
        }
    }
}
