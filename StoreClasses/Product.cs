using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses
{
    public class Product
    {
        private double _price;

        public string Name { get; set; }
        public string Category { get; set; }
        public double Price 
        {
            get => _price;
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }

        
    }
}
