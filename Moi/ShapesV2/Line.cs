using SixLabors.ImageSharp;
namespace ShapesV2;

public class Line
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }
    public Color DrawColor { get; set; }

    public Line(Point startPoint, Point endPoint, Color drawColor)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
        DrawColor = drawColor;
    }
    
    public void Draw(Canvas canvas)
    {
        if (StartPoint.X == EndPoint.X)
        {
            VLine vLine = new VLine(new Point(Math.Min(StartPoint.X, EndPoint.X), StartPoint.Y), Math.Abs(StartPoint.Y - EndPoint.Y), DrawColor);
            return;
        }
        
        double m = Convert.ToDouble(EndPoint.Y - StartPoint.Y) / (EndPoint.X - StartPoint.X);
        double b = EndPoint.Y - m * EndPoint.X;
        
        if (Math.Abs(m) < 1)
        {
            int minX = Math.Min(StartPoint.X, EndPoint.X);
            int maxX = Math.Max(StartPoint.X, EndPoint.X);

            for (int x = minX; x <= maxX; x++)
            {
                int y = Convert.ToInt32(Math.Round(m * x + b, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, DrawColor);
            }
        }
        else
        {
            int minY = Math.Min(StartPoint.Y, EndPoint.Y);
            int maxY = Math.Max(StartPoint.Y, EndPoint.Y);

            for (int y = minY; y <= maxY; y++)
            {
                int x = Convert.ToInt32(Math.Round((y - b) / m, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, DrawColor);
            }
        }
    }
}