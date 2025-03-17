using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG.Online
{
    public class DemoSpawner : MonoBehaviour
    {
        private void Start()
        {
            PhotonNetwork.Instantiate("Hunter", Vector3.zero,Quaternion.identity);
        }
    }
}
