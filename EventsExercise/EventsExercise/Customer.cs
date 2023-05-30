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
    internal class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        private Product _product;

        public Customer(string firstname, string lastname, Product product)
        {
            Firstname = firstname;
            Lastname = lastname;
            _product = product;
            //Subscribe 
            product.OnPriceChange += Product_OnPriceChange;
        }

        private void Product_OnPriceChange(Product pr, double newPrice)
        {
            Console.WriteLine($"Hi {this.Firstname}, the price for {pr.Desc} " +
                $"has changed to {newPrice.ToString("C2")}");
        }
    }
}
