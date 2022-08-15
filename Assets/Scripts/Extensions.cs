using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions
{
    

    static public string StringAll<T>(this List<T> list)
    {
        string str = "";
        foreach (var item in list)
        {
            str += $"{item.ToString()},";
        }
        return str;
    }

    static public string Info(this Transform tf)
    {
        var p = tf.position;
        var r = tf.rotation;
        var s = tf.localScale;
        string str = $"{tf.name} p:{p} r:{r.eulerAngles} s:{s}";
        return str;
    }
}
