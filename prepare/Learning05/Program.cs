using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.SetColor("Green");
        square.SetSide(5);


        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Blue");
        rectangle.SetLength(5);
        rectangle.SetWidth(8);

        Console.WriteLine();
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle();
        circle.SetColor("Yellow");
        circle.SetRadius(4);

        Console.WriteLine();
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());


        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
    }
}