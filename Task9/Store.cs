using System;
using System.Collections.Generic;
using Task9.Products;

namespace Task9
{
    public class Store
    {
        private readonly Random _random = new();
        private readonly List<Product> _productsInStock = new();
        private const int MaxProducts = 20;

        private readonly List<string> _productNames = new()
        {
            "Fish", "Milk", "Salt", "Corn"
        };

        private string GetRandomStoragePlace()
        {
            var die = _random.Next(0, 2);
            var storagePlace = die == 0 ? StoragePlaces.Icebox : StoragePlaces.Showcase;
            return storagePlace;
        }

        private DateTime GetRandomDeliveryTime()
        {
            var minusDays = _random.Next(1, 200);
            var deliveryTime = DateTime.Now.AddDays(-minusDays);
            return deliveryTime;
        }


        public Store()
        {
            InitializeStore();
        }

        private void InitializeStore()
        {
            for (var i = 0; i < MaxProducts; i++)
            {
                var random = new Random();
                var productName = _productNames[random.Next(0, _productNames.Count)];

                var storagePlace = GetRandomStoragePlace();
                var deliveryTime = GetRandomDeliveryTime();
                Product productToAdd = productName switch
                {
                    "Fish" => new Fish(storagePlace, deliveryTime),
                    "Milk" => new Milk(storagePlace, deliveryTime),
                    "Salt" => new Salt(storagePlace, deliveryTime),
                    "Corn" => new Corn(storagePlace, deliveryTime),
                    _ => throw new Exception("Tak ne doljno bit!"),
                };

                _productsInStock.Add(productToAdd);
            }
        }

        public void Show()
        {
            Console.WriteLine("Product | Delivered at | Storage place | S. life days | Fresh");
            foreach (var productInStock in _productsInStock)
            {
                Console.WriteLine($"{productInStock.Name} | {productInStock.DeliveryTimeStamp} | {productInStock.StoragePlace} | {productInStock.StorageLifeDays} | {productInStock.IsFresh()}");
            }
        }
    }
}