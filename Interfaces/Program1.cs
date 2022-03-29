using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var square1 = new Square(10);
            var square2 = new Square(12);
            DoubleSquare hui = new DoubleSquare();
            hui.BuildDoubleSquare(square1, square2);
            Console.WriteLine($"The area of double square is {hui.GetArea()}");
        }
    }
}

