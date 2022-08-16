using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager
{
    protected Dictionary<string, GameObject> map = new Dictionary<string, GameObject>();

    public void AddCube(float x, float y)
    {
        string key = $"{x}_{y}";
        map.Add(
            key,
            GameObject.CreatePrimitive(PrimitiveType.Cube)
                .Position(x, y)
                //.Rotation(0, 0, 45)
                //.Scale(0.8f)
        ); ;
    }

    public void AddCube(string key)
    {
        var v = key.MapCell().ToFloatArray();
        map.Add(
            key,
            GameObject.CreatePrimitive(PrimitiveType.Cube)
                .Position(v)
        );
    }
}
