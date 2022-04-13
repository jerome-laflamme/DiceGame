


using ShapesV2;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Point = ShapesV2.Point;
using Rectangle = ShapesV2.Rectangle;

namespace DrawShapesV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string image_file = "ex4.png";
            string filename = Path.Combine(docs, image_file);
            
            Canvas canvas = new Canvas(1800,2000, Color.Navy);

            Point p1 = new Point(100, 50, Color.White);
            p1.Draw(canvas);
            p1.X = 200;
            p1.Draw(canvas);
            p1.Y = 25;
            p1.Draw(canvas);

            // VERTICAL LINE
            VLine vLine = new VLine(new Point(200, 100), 60, Color.White);
            vLine.Draw(canvas);
            //HORIZONTAL LINE
            HLine hLine = new HLine(new Point(300, 500), 150, Color.White);
            hLine.Draw(canvas);
            //DRAW LINE
            Line line = new Line(new Point(1000, 1200), new Point(1500, 1600), Color.White);
            line.Draw(canvas);
            //RECTANGLE
            Rectangle rectangle = new Rectangle(new Point(700, 800), 50, 60, Color.White);
            rectangle.Draw(canvas);
            // TRIANGLE
            Point P1 = new Point(500, 300);
            Point P2 = new Point(600, 200);
            Point P3 = new Point(700, 260);
            Triangle triangle = new Triangle(P1, P2, P3, Color.White);
            triangle.Draw(canvas);
            // CIRCLE
            Circle circle = new Circle(new Point(1500, 500), 100, Color.White);
            circle.Draw(canvas);

            Console.WriteLine($"Writing image in file: {filename}");
            canvas.Save(filename);
        }
    }
}