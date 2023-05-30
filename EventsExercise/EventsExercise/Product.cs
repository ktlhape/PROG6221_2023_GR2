using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExercise
{
    /// <summary>
    /// Publisher class
    /// </summary>

    internal class Product
    {
        public delegate void PriceChanged(Product pr, double price);
        public event PriceChanged OnPriceChange;
        public string Desc { get; set; }
        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value == 18.00)
                {
                    _price = value;
                    OnPriceChange.Invoke(this, _price);
                }
            }
        }

        public Product(string desc, double price)
        {
            Desc = desc;
            _price = price;
        }
    }
}
