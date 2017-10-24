using UnityEngine;

public class Point
{
    public static Point Zero = new Point(0, 0);
    public static Point Up = new Point(1, 0);
    public static Point Down = new Point(-1, 0);
    public static Point Left = new Point(0, -1);
    public static Point Right = new Point(0, 1);
    public static Point UpRight = new Point(1, 1);
    public static Point UpLeft = new Point(1, -1);
    public static Point DownRight = new Point(-1, 1);
    public static Point DownLeft = new Point(-1, -1);

    public int X;
    public int Y;

    public Point() {}
    
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public static Point GetPoint(EDirection direction)
    {
        switch (direction) {
            case EDirection.Up: return Up;
            case EDirection.UpLeft: return UpLeft;
            case EDirection.Left: return Left;
            case EDirection.DownLeft: return DownLeft;
            case EDirection.Down: return Down;
            case EDirection.DownRight: return DownRight;
            case EDirection.Right: return Right;
            case EDirection.UpRight: return UpRight;
            default: return Zero;
        }
    }

    public static float Distance(Point p1, Point p2)
    {
        var t1 = p2.X - p1.X;
        var t2 = p2.Y - p1.Y;
        return Mathf.Sqrt( t1*t1 + t2*t2 );
    }

    public Point(Point point) : this(point.X, point.Y) {}

    public static Point operator+ (Point left, Point right)
    {
        return new Point(left.X + right.X, left.Y + right.Y);
    }

    public static Point operator- (Point left, Point right)
    {
        return new Point(left.X - right.X, left.Y - right.Y);
    }

    public static Point operator* (Point left, int scale)
    {
        return new Point(left.X * scale, left.Y * scale);
    }

    public override int GetHashCode()
    {
        return X * 100000 + Y;
    }

}