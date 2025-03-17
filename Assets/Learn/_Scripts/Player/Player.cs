using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG.Online
{
    public class Player : MonoBehaviour
    {
        private PlayerHealth playerHealth;
        private PlayerAnimation playerAnimation;
        private PlayerMana playerMana;
        private void Awake()
        {
            playerHealth = GetComponent<PlayerHealth>();
            playerAnimation = GetComponent<PlayerAnimation>();
            playerMana = GetComponent<PlayerMana>();
        }

        public void RevivalCharacter()
        {
            playerHealth.RevivalCharacter();
            playerAnimation.AnimRevival();
            playerMana.RevivalCharacter();
        }
    }

}