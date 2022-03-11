using System;

namespace Task9.Products
{
    public class Salt : Product
    {
        private const double IceboxLifeDays = double.PositiveInfinity;
        private const double ShowcaseLifeDays = double.PositiveInfinity;

        public override string Name => nameof(Salt);

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


        public Salt(string storagePlace, DateTime deliveryTimeStamp)
            : base(storagePlace, deliveryTimeStamp)
        {
        }
    }
}