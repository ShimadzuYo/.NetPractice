using System;

namespace Task9.Products
{
    public class Milk : Product
    {
        private const double IceboxLifeDays = 60;
        private const double ShowcaseLifeDays = IceboxLifeDays / 6;

        public override string Name => nameof(Milk);

        public override double StorageLifeDays
        {
            get
            {
                return StoragePlace switch
                {
                    StoragePlaces.Icebox => IceboxLifeDays,
                    StoragePlaces.Showcase => ShowcaseLifeDays,
                    _ => throw new ArgumentException(nameof(StoragePlace), $"Undefined storage place! - {StoragePlace}")
                };
            }
        }

        public Milk(string storagePlace, DateTime deliveryTimeStamp)
            : base(storagePlace, deliveryTimeStamp)
        {
        }
    }
}