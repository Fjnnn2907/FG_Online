using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DemoPhoton : SimulationBehaviour, IPlayerJoined
{
    [SerializeField] protected GameObject playerFrefab;
    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer)
             Runner.Spawn(playerFrefab,new Vector3(0, 1, 0), Quaternion.identity);
    }
}
