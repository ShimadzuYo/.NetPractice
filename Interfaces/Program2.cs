// See https://aka.ms/new-console-template for more information


using System;

public class Proram
{
    public static void Main1()
    {
        var square1 = new Square(10);
        var square2 = new Square(12);
        var doubleSquare = new DoubleSquare();
        doubleSquare.BuildDoubleSquare(square1, square2);
        Console.WriteLine("Площадь doubleSquare = {0}", doubleSquare.GetArea());
    }
}

public class Square : ISquare
{
    private readonly double _side;

    public Square(double side)
    {
        _side = side;
    }

    public double GetSide()
    {
        return _side;
    }

    public double GetArea()
    {
        return _side * _side;
    }
}

public class DoubleSquare : AbstractDoubleSquare
{
    private ISquare _square1;
    private ISquare _square2;


    public override void BuildDoubleSquare(ISquare square1, ISquare square2)
    {
        _square1 = square1;
        _square2 = square2;
    }

    protected override double CalculateArea()
    {
        return _square1.GetArea() + _square2.GetArea();
    }
}

public interface IFigure
{
    double GetArea();
}

public interface ISquare : IFigure
{
    double GetSide();
}

public interface IDoubleSquare : IFigure
{
    void BuildDoubleSquare(ISquare square1, ISquare square2);
}

public abstract class AbstractDoubleSquare : IDoubleSquare
{
    protected double area;

    public abstract void BuildDoubleSquare(ISquare square1, ISquare square2);

    protected abstract double CalculateArea();

    public double GetArea()
    {
        if (area == 0)
        {
            area = CalculateArea();
        }

        return CalculateArea();
    }
}