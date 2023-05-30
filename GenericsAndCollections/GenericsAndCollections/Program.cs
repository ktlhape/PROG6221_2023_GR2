using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine(IsEqual<int>(6,7));
            Console.WriteLine(IsEqual<string>("A","a"));
            Console.WriteLine(IsEqual<double>(6.1,6));
            Console.WriteLine(IsEqual<char>('c','C'));

            Console.WriteLine("========================");
            Console.WriteLine(IsEqual<string,int>("Kabelo",6));

            Console.Read();
        }
        /// <summary>
        /// Check if two objects are equal
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>True if x is equals to y, otherwise returns false</returns>
        static bool IsEqual<T>(T x, T y)
        {
            if (x.GetType() == typeof(string) || x.GetType() == typeof(char))
            {
                return x.ToString().ToUpper()
                    .Equals(y.ToString().ToUpper());
            }
            return x.Equals(y);
        }

        static bool IsEqual<T1, T2>(T1 x, T2 y)
        {
              return x.ToString().Length.Equals(y);
        }
    
    }
}
