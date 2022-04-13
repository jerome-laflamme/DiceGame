using SixLabors.ImageSharp;

namespace ShapesV2;

public class Rectangle
{
    
        
    public Point StartPoint { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Color DrawColor { get; set; }

    public Rectangle(Point startPoint, int width, int height, Color drawColor)
    {
        StartPoint = startPoint;
        Height = height;
        Width = width;
        DrawColor = drawColor;
    }

    
    public void Draw(Canvas canvas)
    {
        VLine v1 = new VLine(StartPoint, Height, DrawColor);
        v1.Draw(canvas);
        HLine h1 = new HLine(StartPoint, Width, DrawColor);
        h1.Draw(canvas);
        
        v1.StartPoint.X += Width;
        v1.Draw(canvas);
        
        h1.StartPoint.Y += Height;
        h1.StartPoint.X -= Width;
        h1.Draw(canvas);
    }
}