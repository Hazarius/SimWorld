using System.Collections.Generic;

public class Objects
{
    Dictionary<Point, Block> _map;

    public Block GetObject(Point pt)
    {
        Block block = null;
        _map.TryGetValue(pt, out block);
        return block;
    }

    public bool AddObject(Block block)
    {
        if (!_map.ContainsKey(block.position)) {
            _map.Add(block.position, block);
            return true;
        }
        return false;
    }

    public bool RemoveObject(Block block)
    {
        return RemoveObject(block.position);
    }

    public bool RemoveObject(Point pt)
    {
       if (!_map.ContainsKey(pt)) {
            _map.Remove(pt);
            return true;
        }
         return false;
    }
}
