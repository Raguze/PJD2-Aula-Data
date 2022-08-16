using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public MapManager map = new MapManager();

    public List<int> listInt;

    private void Awake()
    {
        map.AddCube(2, 3);
        map.AddCube(1, 5);

        listInt = new List<int>() {
            1,5,3,87,4,65,94
        };

        Debug.Log(listInt.StringAll());

        List<string> names = new List<string>() {
            "Megaman","Zero","Batman"
        };
        Debug.Log(names.StringAll());

        Debug.Log(transform);
        Debug.Log(transform.Info());

        Vector3 v = new Vector3(0, 2, 5);
        Float3 f0 = new Float3()
        {
            f0 = v.x,
            f1 = v.y,
            f2 = v.z
        };

        Float3 f1 = v.ToFloat3();

        //Debug.Log("1".Split("_").StringAll());
        Debug.Log("1_2".Split("_").StringAll());
        Debug.Log("1_2".MapCell());
        Debug.Log("1_2_4".Split("_").StringAll());
        Debug.Log("1_2_4".MapCell());

        var go = new GameObject("Test");
        go.Position(2)
            .Rotation(0, 30)
            .Scale(2, 1, 5)
            .AddComponent<BoxCollider>();

        var go1 = new GameObject("Test2");
        var comp = go1.AddComponent<CapsuleCollider>();
        comp.Scale(2);
    }
}
