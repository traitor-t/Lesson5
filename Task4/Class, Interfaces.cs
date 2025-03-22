interface IDraw
{
    void ApplyColor(string color);
}

interface IPaint
{
    void ApplyColor(string color);
}

class GraphicEditor : IDraw, IPaint
{
    void IDraw.ApplyColor(string color)
    {
        Console.WriteLine($"Цвет для рисования применен: {color}");
    }

    void IPaint.ApplyColor(string color)
    {
        Console.WriteLine($"Цвет для покраски применен: {color}");
    }
}