using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                        //5
            int[] arNums = { 2,7,12,8,10,5};
            int sum = 0;
            int position = -1;
            for (int i = 0; i < arNums.Length; i++)
            {
                if (arNums[i] == 12)
                {
                    position = i;
                }
                if (arNums[i] % 2 == 0)
                {
                    sum = sum + arNums[i];
                }
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Position of 12 is: " + position);


        }
    }
}
