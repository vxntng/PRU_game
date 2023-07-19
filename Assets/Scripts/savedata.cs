using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class savedata
{
    public int highScore;

    public string SaveToJSON()
    {
        return JsonUtility.ToJson(this);
    }

    public static savedata LoadFromJSON(string json)
    {
        return JsonUtility.FromJson<savedata>(json);
    }



}
