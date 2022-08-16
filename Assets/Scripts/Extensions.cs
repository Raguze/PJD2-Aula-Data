using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class Extensions
{
    static public GameObject Position (this GameObject gameObject,params float[] ps)
    {
        gameObject.transform.position = Vector3.zero.New(ps);
        return gameObject;
    }

    static public GameObject Rotation(this GameObject gameObject, params float[] ps)
    {
        gameObject.transform.rotation = Quaternion.Euler(Vector3.zero.New(ps));
        return gameObject;
    }

    static public GameObject Scale(this GameObject gameObject, params float[] ps)
    {
        gameObject.transform.localScale = Vector3.zero.New(ps);
        return gameObject;
    }

    static public GameObject Scale(this GameObject gameObject, float ps)
    {
        gameObject.transform.localScale = Vector3.zero.New(ps,ps,ps);
        return gameObject;
    }
    static public Component Position(this Component component, params float[] ps)
    {
        component.transform.position = Vector3.zero.New(ps);
        return component;
    }

    static public Component Rotation(this Component component, params float[] ps)
    {
        component.transform.rotation = Quaternion.Euler(Vector3.zero.New(ps));
        return component;
    }

    static public Component Scale(this Component component, params float[] ps)
    {
        component.transform.localScale = Vector3.zero.New(ps);
        return component;
    }

    static public Component Scale(this Component component, float ps)
    {
        component.transform.localScale = Vector3.zero.New(ps, ps, ps);
        return component;
    }

    static public string StringAll<T>(this ICollection<T> list)
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

    static public Float3 ToFloat3(this Vector3 v3)
    {
        var f3 = new Float3()
        {
            f0 = v3.x,
            f1 = v3.y,
            f2 = v3.z,
        };
        return f3;
    }

    //var vs = str.Split("_").Select(float.Parse).ToArray();

    static public Vector3 New (this Vector3 v,params float[] values)
    {
        switch (values.Length)
        {
            case 1:
                return new Vector3(values[0], 0);
            case 2:
                return new Vector3(values[0], values[1]);
            case 3:
                return new Vector3(values[0], values[1], values[2]);
            default:
                throw new System.Exception($"Values deve ter entre 1 e 3 valores");

        }
    }

    static public Vector3 MapCell(this string str)
    {
        //var vs = str.Split("_").Select(s => float.Parse(s));
        var vs = str.Split("_").Select(float.Parse);
        var fs = vs.ToArray();
        return Vector3.zero.New(fs);
    }

    static public float[] ToFloatArray(this Vector3 v)
    {
        return new float[]
        {
            v.x,
            v.y,
            v.z
        };
    }
}
