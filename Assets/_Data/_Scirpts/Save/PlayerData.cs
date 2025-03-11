using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData : ISave
{
    public int id;
    public string name;

    public string Save()
    {
        return JsonUtility.ToJson(this, true);
    }

    public void Load(string json)
    {
        JsonUtility.FromJsonOverwrite(json, this);
    }
}
