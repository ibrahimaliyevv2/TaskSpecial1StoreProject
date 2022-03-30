using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses
{
    public class Store
    {
        public Store()
        {
            this._products = new Product[0];
        }
        private Product[] _products;
        public Product[] Products
        {
            get => _products;
        }
        public int ProductLimit { get; set; }
        public string  Name { get; set; }

        public void AddProduct(Product product)
        {
            if (this.ProductLimit > this._products.Length)
            {
                Array.Resize(ref this._products, this._products.Length + 1);
                this._products[this._products.Length - 1] = product;
            }
        }

        public void GetProductsByCategory(string category)
        {
            foreach (var item in Products)
            {
                if (category == item.Category)
                {
                    Console.WriteLine($"Name: {item.Name}");
                }
            }
            
        }
    }
}
