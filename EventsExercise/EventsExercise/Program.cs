using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExercise
{
    /// <summary>
    /// Subscriber class
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product("Fanta",12.00);
            Customer cust = new Customer("James", "Smith", pr);

            //Subscribe to an event
            //pr.OnPriceChange += Notify;

            pr.Price = 18.50;
            pr.Price = 18.00; // 1
            pr.Price = 17.50;
            pr.Price = 18.00; // 2
            pr.Price = 25.50;
            pr.Price = 18.00; // 3
           
        }
        //static void Notify(Product product, double newPrice)
        //{
        //    Console.WriteLine($"Hi, the price for {product.Desc} " +
        //        $"has changed to {newPrice.ToString("C2")}");
        //}
    }
}
