using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercise
{
    internal class Program
    {
        public delegate bool Filter(int x);
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 
            5,15,20,31,4,81
            };
            Display(numbers, x => x % 2 == 0);
            Console.WriteLine("=============");
            Display(numbers, IsOdd);
        }
        //static bool IsEven(int x) => x % 2 == 0;
        static bool IsOdd(int x) => x % 2 != 0;
        static void Display(List<int> ar, Filter filter)
        {
            foreach (int num in ar)
            {
                if (filter(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

    }
}
