using System.Collections.Generic;
using System;
using System.Data.SqlTypes;
using System.Linq;

namespace Task9
{
    public class Store
    {
        private readonly List<Product> _productsInStock = new();
        private const int MaxProd = 20;

        private readonly List<string> _productNames = new()
        {
            "Fish",  "Milk"
        };

        private void GetRandomStoragePlace(Product subject)
        {
            var random = new Random();
            var die = random.Next(1, 2);
            var storagePlace = die == 2 ? "Icebox" : "Showcase";
            subject.storagePlace = storagePlace;


        }

        private DateTime GetRandomDeliveryTime()
        {
            
            var random = new Random();
            var minusDays = random.Next(1,200);
            DateTime deliveryTime = DateTime.Now.AddDays(-minusDays);
            return deliveryTime;
        }


        public Store()
        {
            do
            {
                var random = new Random();
                var productName = _productNames[random.Next(0, _productNames.Count)];
                
                var deliveryTime = GetRandomDeliveryTime();
                Product productToAdd = productName switch
                {
                    "Fish" => new Fish(storagePlace, deliveryTime),
                    "Milk" => new Milk(storagePlace, deliveryTime),
                    _ => null
                };
                GetRandomStoragePlace(productToAdd);
                _productsInStock.Add(productToAdd);
                
            } while (_productsInStock.Count < MaxProd);
           

            foreach (var productInStock in _productsInStock)
            {
                // productInStock.IsFresh();
                Console.WriteLine($"{productInStock.Name} {productInStock.DeliveryTimeStamp} {productInStock.StorageLifeDays} ");
            }
        }
    }
}