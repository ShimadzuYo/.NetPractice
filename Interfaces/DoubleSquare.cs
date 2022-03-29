using System;

namespace Interfaces
{
    public class DoubleSquare : AbstractDoubleSquare
    {
        private double _doubleSquare;

        public override void BuildDoubleSquare(ISquare square1, ISquare square2)
        {
            _doubleSquare = square1.GetSide() + square2.GetSide();

        }


        private double GetArea(double side1, double side2)
        {
            double area = Math.Pow(side1, 2) + Math.Pow(side2, 2);
            return area;
        }


        protected override double CalculateArea()
        {
            
            return area;    
        }
    }
}