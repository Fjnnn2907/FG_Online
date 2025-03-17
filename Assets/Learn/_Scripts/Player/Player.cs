using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG.Online
{
    public class Player : MonoBehaviour
    {
        private PlayerHealth playerHealth;

        private void Awake()
        {
            playerHealth = GetComponent<PlayerHealth>();
        }

        public void RevivalCharacter()
        {
            playerHealth.RevivalCharacter();
        }
    }

}