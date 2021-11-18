using System.Collections.Generic;
using System;
using System.Data.SqlTypes;
using System.Linq;

namespace Task9
{
    public class Store
    {
        public List<Product> Products = new List<Product>();
        public int maxProd = 20;

        private List<string> namesOfProducts = new()
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
                prod.name = namesOfProducts[nameChoice];
                switch (prod.name)
                {
                    case "Fish":
                        prod.storageLife = 20;
                        break;
                    case "Milk":
                        prod.storageLife = 60;
                        break;
                    case "Salt":
                        prod.storageLife = double.PositiveInfinity;
                        break;
                    case "Corn":
                        prod.storageLife = 150;
                        break;
                    case "Canned meat":
                        prod.storageLife = 180;
                        break;
                }

                Products.Add(prod);
            }

            DetermineStorage(Products);
            DetermineStorageLife(Products);
        }

        public void DetermineStorage(List<Product> subject)
        {
            var random = new Random();

            foreach (var product in subject)
            {
                var storageChoice = random.Next(0, 10);
                if (storageChoice % 2 == 0)
                {
                    product.storagePlace = "freezer";
                }

                if (storageChoice % 2 == 1)
                {
                    product.storagePlace = "shelf";
                }
            }
        }

        public void Inspect(Store subject)
        {
            var theCount = subject.Products.Count;
            Console.WriteLine(theCount);
            foreach (var prod in subject.Products)
            {
                Console.WriteLine($"{prod.name} {prod.storagePlace} {prod.storageLife}");
            }
        }

        public void DetermineStorageLife(List<Product> subject)
        {
            foreach (var product in subject)
            {
                switch (product.name)
                {
                    case "Milk" when product.storagePlace == "shelf":
                        product.storageLife /= 2;
                        break;
                    case "Fish" when product.storagePlace == "shelf":
                        product.storageLife /= 6;
                        break;
                }
            }
        }
    }
}