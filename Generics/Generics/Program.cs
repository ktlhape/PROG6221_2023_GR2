using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            //numbers.Capacity = 3;
            //add items at the end of the list
            numbers.Add(5); //index = 0
            numbers.Add(2); //index = 1
            numbers.Add(8); //index = 2
            numbers.Add(10); //index = 3
            numbers.Add(12); //index = 4
            numbers.Add(18); //index = 5
            numbers.Add(23); //index = 6

            Console.WriteLine("Before changes");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }


            numbers.Insert(2,100); //Add at a specific position
            numbers.Remove(5); //Remove 12
            numbers.RemoveAt(2); //Remove 8 at position 2
            numbers.RemoveRange(4, 2);//remove 12, 18

            Console.WriteLine("After changes");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }



            Console.WriteLine($"Capacity: {numbers.Capacity}" );
            Console.WriteLine($"Count: {numbers.Count}" );

            Console.Read();

        }
    }
}
