using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

using UnityEngine;

public class WorldLoader : MonoBehaviour
{
    public Transform mapRoot;
    public GameObject wall;
    public GameObject floor;
    public GameObject food;
    public TextAsset mapAsset;

    public Dictionary<Point, Block> LoadMap()
    {
        var result = new Dictionary<Point, Block>();
        var sr = new StringReader(mapAsset.text);
		string templine = sr.ReadLine();
        var w = 0;
        var h = 0;
		while (!string.IsNullOrEmpty(templine)) {
            h = 0;
			var line = templine.ToCharArray();
            foreach (char ch in line) {
				switch(ch){
                    case ' ': break;
                    case 'F':
					case '0':
                        result.Add(new Point(w, h), new Floor());
					break;
                    case 'W':
					case '1':
						result.Add(new Point(w, h), new Wall());
					break;
					default :
						Debug.LogWarningFormat("Can't read %1", ch);
						break;
				}
                h++;
		    }
            w++;
            templine = sr.ReadLine();
        }
        sr.Dispose();
        return result;
	}

    public void CreateWorld(Map map)
    {
        foreach(var pair in map._map) {

            if (pair.Value is Wall) {
                var item = Instantiate(wall, WorldHelper.GetPosition(pair.Key), Quaternion.identity);
                item.AddComponent<WallView>();
                item.transform.SetParent(mapRoot);
            }

            if (pair.Value is Floor) {
                 var item = Instantiate(floor, WorldHelper.GetPosition(pair.Key), Quaternion.identity);
                item.AddComponent<FloorView>();
                item.transform.SetParent(mapRoot);
            }
        }
    }
}