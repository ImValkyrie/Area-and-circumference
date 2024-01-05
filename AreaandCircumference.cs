using System;
using System.Collections.Generic;

class Shape
{
    public virtual double GetCircumference()
    {
        return 0;  
    }

    public virtual double GetArea()
    { 
        return 0; 
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }
}
class Rectangle : Shape
{
    public double Lenght { get; set; }
    public double Width { get; set; }

    public Rectangle(double lenght, double width)
    {
        Lenght = lenght;
        Width = width;
    }

    public override double GetCircumference()
    {
        return 2 * (Lenght + Width);
    }

    public override double GetArea()
    {
        return Lenght * Width;
    }
}

class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
    }
}

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4,10),
            new Square(7)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{ shape.GetType().Name} circumferance is { shape.GetCircumference()}");
            Console.WriteLine($"{ shape.GetType().Name }area is {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}