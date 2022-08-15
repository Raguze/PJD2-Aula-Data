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


    }
}
