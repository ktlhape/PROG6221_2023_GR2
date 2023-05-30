using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = 5.9;
            //Convert 5.9 to and int type
            int z = Convert.ToInt32(y);
            //Convert y to and int type
            int j = (int)y; //Cast

            Student st = new Student();
            Person p = new Person();

            People pe = new Student();
            pe = (People)st; //Casting

            string name = "lll";
            int ab = 5;
            name = ab.ToString();

            Console.WriteLine(z);
            Console.Read();
        }
    }
}
