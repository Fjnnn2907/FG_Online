using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
    public string transtitonName;
    protected virtual string NameArena()
    {
        return PlayerCtrl.instance.arenaName;
    }


}
