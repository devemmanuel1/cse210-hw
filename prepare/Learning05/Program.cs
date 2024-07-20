using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 2);
        Rectangle rectangle = new Rectangle("Green", 2, 3);
        Circle circle = new Circle("Yellow", 3);

        List<Shape> shapes = [square, rectangle, circle];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}