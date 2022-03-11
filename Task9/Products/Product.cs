using System;

namespace Task9.Products
{
    public abstract class Product
    {
        public abstract string Name { get; }
        public abstract double StorageLifeDays { get; }
        public string StoragePlace { get; }
        public DateTime DeliveryTimeStamp { get; }

        public bool IsFresh() // у этого метода логика для всех одинаковая, поэтому можно здесь один раз написать, как он будет работать 
        {
            var today = DateTime.Today;
            var difference = DeliveryTimeStamp - today;
            var convertedDifference = difference.TotalDays;
            if (convertedDifference > StorageLifeDays)
            {
                return false;
            }

            return true;
        }

        protected Product(string storagePlace, DateTime deliveryTimeStamp)
        {
            StoragePlace = storagePlace;
            DeliveryTimeStamp = deliveryTimeStamp;
        }
    }
}