abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;
    
    public Rectangle(double width, double height)
    {
        this.width = width; 
        this.height = height;
    }
    public override double GetArea()
    {
        return width * height;
    }
}

class Triangle : Shape
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override double GetArea()
    {
        return 0.5 * baseLength * height;
    }
}
