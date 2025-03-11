using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaEnter : Arena
{
    private void Start()
    {
        if(transtitonName == NameArena())
        {
            PlayerCtrl.instance.transform.position = transform.position;
        }
    }
}
