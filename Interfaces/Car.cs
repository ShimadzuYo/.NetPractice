using System;

namespace Interfaces
{
    public class Car:ISpeedCalculator
    {
        private string model;
        private double price;
        private int speed;
        public string Model
        {
            get => model;
            set => model = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public int SpeedProp
        {
            get => speed;
            set => speed = value;
        }

        public Car(string model, double price)
        {
            Model = model;
            Price = price;
        }

        public void Speed()
        {
            var rand = new Random();
            SpeedProp = rand.Next(0, 100);
            
        }

        public void OutputCarInfo(Car car)
        {
            Console.WriteLine($"Car - {model}, price - {price}, speed - {speed}");
        }
    }

    
}

