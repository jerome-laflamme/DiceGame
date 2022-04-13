using ShapesV1;
using SixLabors.ImageSharp;

namespace DrawShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string image_file = "ex1.png";
            string filename = Path.Combine(docs, image_file);
            
            Canvas canvas = new Canvas(500,200, Color.Navy);
            Draw.DrawHLine(canvas, 10, 20, 50, Color.White);
            Draw.DrawVLine(canvas, 50, 100, 50, Color.White);
            Draw.DrawRectangle(canvas, 30, 50, 30, 10, Color.White);
            Draw.DrawSquare(canvas, 60, 60, 60, Color.White);
            Draw.DrawLine(canvas, 50, 100, 350, 50, Color.White);
            Draw.DrawLine(canvas, 250, 200, 245, 50, Color.White);
            Draw.DrawTriangle(canvas, 200, 100, 260, 80,  220,190, Color.White);
            Draw.DrawCircle(canvas, 335, 100, 50, Color.White);
            
            Console.WriteLine($"Writing image in file: {filename}");
            canvas.Save(filename);
        }
    }
}