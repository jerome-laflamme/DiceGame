using ShapesV1;
using SixLabors.ImageSharp;

namespace ShapesV2;

public class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
    public Color DrawColor { get; set; }

    public Circle(Point center, int radius, Color drawColor)
    {
        Center = center;
        Radius = radius;
        DrawColor = drawColor;
    }

    public void Draw(Canvas canvas) 
    {
        int cos45 = Convert.ToInt32(Math.Round(Radius * Math.Cos(Math.PI/4), MidpointRounding.AwayFromZero));
        
        for (int i = 0; i <= cos45; i++)
        {
            int j = Convert.ToInt32(Math.Round(Math.Sqrt(Radius * Radius - i * i), MidpointRounding.AwayFromZero));
            canvas.SetPixel(Center.X+i, Center.Y+j, DrawColor); // point 1
            canvas.SetPixel(Center.X-i, Center.Y+j, DrawColor); // point 2: symétrie du point 1 par rapport à l'axe Y 
            
            canvas.SetPixel(Center.X+i, Center.Y-j, DrawColor); // point 3: symétrie du point 1 par rapport à l'axe X
            canvas.SetPixel(Center.X-i, Center.Y-j, DrawColor); // point 4: symétrie du point 3 par rapport à l'axe Y
            
            canvas.SetPixel(Center.X+j, Center.Y+i, DrawColor); // point 5: symétrie du point 1 par rapport à la diagonale 45°
            canvas.SetPixel(Center.X+j, Center.Y-i, DrawColor); // point 6: symétrie du point 5 par rapport à l'axe X
            
            canvas.SetPixel(Center.X-j, Center.Y+i, DrawColor); // point 7: symétrie du point 5 par rapport à l'axe Y
            canvas.SetPixel(Center.X-j, Center.Y-i, DrawColor); // point 8: symétrie du point 7 par rapport à l'axe X
        }
    }
}
