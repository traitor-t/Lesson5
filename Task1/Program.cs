class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = new Shape[]
        {
            new Circle(5),
            new Rectangle(4,6),
            new Triangle(3,7)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Площадь фигуры : {shape.GetArea()}");
        }
    }
}