using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG.Online
{
    public class PlayerMana : MonoBehaviour
    {
        [SerializeField] private float startMana;
        [SerializeField] private float maxMana;
        [SerializeField] private float regenManaPerSecond;

        private PlayerHealth playerHealth;
        public float Mana { get;private set; }

        private void Start()
        {
            playerHealth = GetComponent<PlayerHealth>();
            Mana = maxMana;
            UpdateManaBar();

            InvokeRepeating(nameof(RegenManaPerSecond), 1, 1);
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.G))
                UseMana(10);
        }
        public void UseMana(float mana)
        {
            if(Mana <= mana) return;
            
            Mana -= mana;
            UpdateManaBar();
        }
        private void UpdateManaBar()
        {
            UIManager.Instance.UpdateMana(Mana,maxMana);
        }
        private void RegenManaPerSecond()
        {
            if(playerHealth.health <= 0 || Mana >= maxMana)
                return;

            Mana += regenManaPerSecond;
            UpdateManaBar();
        }
        public void RevivalCharacter()
        {
            Mana = startMana;
            UpdateManaBar();
        }
    }

}