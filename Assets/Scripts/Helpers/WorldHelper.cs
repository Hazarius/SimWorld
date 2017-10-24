using UnityEngine;

public static class WorldHelper
{
    public const float BlockSize = 4.2f;
    public static Vector3 GetPosition(Point point)
    {
        return new Vector3(point.Y * BlockSize, -point.X * BlockSize, 0);
    }

    
}