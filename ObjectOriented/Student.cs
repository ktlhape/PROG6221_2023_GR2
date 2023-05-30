using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Student
    {
        private string studentID;
    
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


    }
}
