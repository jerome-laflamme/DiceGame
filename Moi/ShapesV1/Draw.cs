using SixLabors.ImageSharp;

namespace ShapesV1;

public class Draw
{
    public static void DrawHLine(Canvas canvas, int x, int y, int width, Color color)
    {
        if (y >= 0 && y < canvas.Height)
        {
            for (int i = Math.Max(x, 0); i < x + width && i < canvas.Width; i++)
            {
                canvas.SetPixel(i, y, color);
            }
        }
    }

    public static void DrawVLine(Canvas canvas, int x, int y, int height, Color color)
    {
        if (x >= 0 && x < canvas.Width)
        {
            for (int i = Math.Max(y, 0); i < y + height && i < canvas.Height; i++)
            {
                canvas.SetPixel(x, i, color);
            }
        }
    }

    public static void DrawLine(Canvas canvas, int x1, int y1, int x2, int y2, Color color)
    {
        if (x1 == x2)
        {
            DrawVLine(canvas, x1, Math.Min(y1, y2), Math.Abs(y2 - y1) + 1, color);
            return;
        }
        
        double m = Convert.ToDouble(y2 - y1) / (x2 - x1);
        double b = y2 - m * x2;
        
        if (Math.Abs(m) < 1)
        {
            int minX = Math.Min(x1, x2);
            int maxX = Math.Max(x1, x2);

            for (int x = minX; x <= maxX; x++)
            {
                int y = Convert.ToInt32(Math.Round(m * x + b, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, color);
            }
        }
        else 
        {
            int minY = Math.Min(y1, y2);
            int maxY = Math.Max(y1, y2);

            for (int y = minY; y <= maxY; y++)
            {
                int x = Convert.ToInt32(Math.Round((y - b) / m, MidpointRounding.AwayFromZero));
                canvas.SetPixel(x, y, color);
            }
        }
    }

    public static void DrawRectangle(Canvas canvas, int x, int y, int width, int height, Color color)
    {
        DrawHLine(canvas, x, y, width, color);
        DrawHLine(canvas, x, y + height, width, color);
        DrawVLine(canvas, x, y, height, color);
        DrawVLine(canvas, x + width, y, height, color);
    }

    public static void DrawSquare(Canvas canvas, int x, int y, int width, Color color)
    {
        DrawHLine(canvas, x, y, width, color);
        DrawHLine(canvas, x, y +width, width, color);
        DrawVLine(canvas, x, y, width,color);
        DrawVLine(canvas, x + width, y, width, color);
    }

    public static void DrawTriangle(Canvas canvas, int x1, int y1, int x2, int y2, int x3, int y3, Color color)
    {
        DrawLine(canvas, x1, y1, x2, y2, color);
        DrawLine(canvas, x2, y2, x3, y3, color);
        DrawLine(canvas, x1, y1, x3, y3, color);
    }
    
    public static void DrawCircle(Canvas canvas, int x, int y, int radius, Color color)
    {
        int cos45 = Convert.ToInt32(Math.Round(radius * Math.Cos(Math.PI/4), MidpointRounding.AwayFromZero));
        
        for (int i = 0; i <= cos45; i++)
        {
            int j = Convert.ToInt32(Math.Round(Math.Sqrt(radius * radius - i * i), MidpointRounding.AwayFromZero));
            canvas.SetPixel(x+i, y+j, color); // point 1
            canvas.SetPixel(x-i, y+j, color); // point 2: sym??trie du point 1 par rapport ?? l'axe Y 
            
            canvas.SetPixel(x+i, y-j, color); // point 3: sym??trie du point 1 par rapport ?? l'axe X
            canvas.SetPixel(x-i, y-j, color); // point 4: sym??trie du point 3 par rapport ?? l'axe Y
            
            canvas.SetPixel(x+j, y+i, color); // point 5: sym??trie du point 1 par rapport ?? la diagonale 45??
            canvas.SetPixel(x+j, y-i, color); // point 6: sym??trie du point 5 par rapport ?? l'axe X
            
            canvas.SetPixel(x-j, y+i, color); // point 7: sym??trie du point 5 par rapport ?? l'axe Y
            canvas.SetPixel(x-j, y-i, color); // point 8: sym??trie du point 7 par rapport ?? l'axe X
        }
    }
}