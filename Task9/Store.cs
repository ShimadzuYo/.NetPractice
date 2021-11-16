using System.Collections.Generic;
using System;
using System.Linq;

namespace Task9
{
    public class Store
    {
        public List<Product> Products = new List<Product>();
        public int maxProd = 20;

        private List<string> namesOfProducts = new List<string>()
        {
            "Fish", "Salt", "Milk", "Canned meat", "Corn"
        };

        public Store()
        {
            var random = new Random();
            
            for (var x = 0; x < maxProd; x++)
            {
                var prod = new Product();
                var nameChoice = random.Next(0, namesOfProducts.Count);
                if (nameChoice == x)
                {
                    prod.name = namesOfProducts[x];
                }

                Products.Add(prod);
            }
        }

        public void Inspection(Store subject)
        {
            var theCount = subject.Products.Count;
            Console.WriteLine(theCount);
            foreach (var prod in subject.Products)
            {
                Console.WriteLine(prod.name);
            }
        }
    }
}