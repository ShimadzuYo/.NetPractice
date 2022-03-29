using System;

namespace Interfaces
{
    public class Square : ISquare
    {
        private double Side { get; set; }


        public Square(double side)
        {
            Side = side;
        }

        public double GetSide()
        {
            return Side;
        }
    }
}