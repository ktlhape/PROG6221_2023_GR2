using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.StudentID = "ST1234";
            st.StudentID = "ST2468";
            Console.WriteLine(st.StudentID);
        }
    }


}
