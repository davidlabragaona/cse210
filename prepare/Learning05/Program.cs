using System;

class Program
{
    static void Main(string[] args)
    {
        //Square square = new Square("red", 20.00);
        //Console.WriteLine ($"{square.GetColor()}-{square.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 20));
        shapes.Add(new Rectangle("Green", 20, 30));
        shapes.Add(new Circle("Blue", 15));

        foreach (Shape shape in shapes) {
            Console.WriteLine($"{shape.GetColor()} - {shape.GetArea()}");
        }
    }
}