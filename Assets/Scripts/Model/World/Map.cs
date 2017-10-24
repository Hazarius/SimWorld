using System.Collections.Generic;

public class Map
{
    public Dictionary<Point, Block> _map;

    public Map(Dictionary<Point, Block> map)
    {
        _map = map;
    }

    public Block GetBlock(Point pt)
    {
        Block block = null;
        _map.TryGetValue(pt, out block);
        return block;
    }
}