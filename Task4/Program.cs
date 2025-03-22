class Program
{
    static void Main(string[] args)
    {
        GraphicEditor editor = new GraphicEditor();
        IDraw drawEditor = editor;
        drawEditor.ApplyColor("Красный");

        IPaint paintEditor = editor;
        paintEditor.ApplyColor("Желтый");
    }
}