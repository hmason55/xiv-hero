namespace XivHero.Models;

public class Rect
{
    public int Left;
    public int Right;
    public int Top;
    public int Bottom;

    public Rect(int left = 0, int right = 1, int bottom = 0, int top = 1)
    {
        Left = left;
        Right = right;
        Bottom = bottom;
        Top = top;
    }

    public Point ClampPosition(Point point)
    {
        return new(Math.Clamp(point.X, Left, Right), Math.Clamp(point.Y, Bottom, Top));
    }

    public bool Contains(Point point)
    {
        return point.X >= Left && point.Y >= Bottom && point.X <= Right && point.Y <= Top;
    }
}
