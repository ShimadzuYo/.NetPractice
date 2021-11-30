using System;

namespace Task9.Products
{
    public class Corn : Product
    {
        private const double IceboxLifeDays = 150;
        private const double ShowcaseLifeDays = IceboxLifeDays;

        public override string Name => nameof(Corn);

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


        public Corn(string storagePlace, DateTime deliveryTimeStamp)
            : base(storagePlace, deliveryTimeStamp)
        {
        }
    }
}