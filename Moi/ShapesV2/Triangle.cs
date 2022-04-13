using SixLabors.ImageSharp;
namespace ShapesV2;

public class Triangle
{
    public Point P1 { get; set; }
    public Point P2 { get; set; }
    public Point P3 { get; set; }
    public Color DrawColor { get; set; }

    public Triangle(Point p1, Point p2, Point p3, Color drawColor)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
        DrawColor = drawColor;
    }

    public void Draw(Canvas canvas)
    {
        Line line1 = new Line(P1, P2, Color.White);
        line1.Draw(canvas);
        Line line2 = new Line(P2, P3, Color.White);
        line2.Draw(canvas);
        Line line3 = new Line(P1, P3, Color.White);
        line3.Draw(canvas);
    }
}