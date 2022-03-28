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
            string filename = docs + "/" + image_file;
            
            Canvas canvas = new Canvas(500,200, Color.White);
            Draw.DrawHLine(canvas, 10, 20, 50, Color.Red);
            
            Console.WriteLine($"Writing image in file: {filename}");
            canvas.Save(filename);
        }
    }
}