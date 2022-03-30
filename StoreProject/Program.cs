using System;
using StoreClasses;

namespace StoreProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Un 1";
            product.Category = "Un mehsullari";

            Product product1 = new Product();
            product1.Name = "Un 2";
            product1.Category = "Un mehsullari";

            Product product2 = new Product();
            product2.Name = "Coca Cola 1L";
            product2.Category = "Ickiler";


            Store hikmetinMarketi = new Store();
            hikmetinMarketi.ProductLimit = 3;
            hikmetinMarketi.AddProduct(product);
            hikmetinMarketi.AddProduct(product1);
            hikmetinMarketi.AddProduct(product2);


            foreach (var item in hikmetinMarketi.Products)
            {
                Console.WriteLine(item.Name);
            }

            hikmetinMarketi.GetProductsByCategory("Ickiler");



        }
    }
}
