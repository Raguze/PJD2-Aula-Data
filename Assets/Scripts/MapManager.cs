using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager
{
    protected Dictionary<string, GameObject> map = new Dictionary<string, GameObject>();

    public void AddCube(float x, float y)
    {
        var go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go.transform.position = new Vector3(x, y);
        string key = $"{x}_{y}";
        map.Add(key, go);
    }
}
