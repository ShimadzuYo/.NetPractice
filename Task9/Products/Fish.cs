using System;

namespace Task9.Products
{
    public class Fish : Product
    {
        private const int IceboxLifeDays = 20;
        private const double ShowcaseLifeDays = (double) IceboxLifeDays / 6;

        public override string Name => nameof(Fish);

        public override double StorageLifeDays
        {
            get
            {
                return StoragePlace switch
                {
                    // по заданию, если холодильник, то 20 дней, иначе в 6 раз меньше
                    StoragePlaces.Icebox => IceboxLifeDays,
                    StoragePlaces.Showcase => ShowcaseLifeDays,
                    _ => throw new ArgumentException(nameof(StoragePlace), $"Undefined storage place! - {StoragePlace}")
                };
            }
        }


        public Fish(string storagePlace, DateTime deliveryTimeStamp)
            : base(storagePlace, deliveryTimeStamp)
        {
        }
    }
}