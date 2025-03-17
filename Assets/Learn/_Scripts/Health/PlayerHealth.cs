using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG.Online
{
    public class PlayerHealth : HealthBase
    {
        public static Action playerDead;
        public bool isDead {  get; private set; }
        public bool isDeffPlayer => health <= maxHealth;
        private BoxCollider2D boxCollider2D;

        protected override void Start()
        {
            base.Start();
            boxCollider2D = GetComponent<BoxCollider2D>();
            UpdateHealthBar(health, maxHealth);
        }
        private void Update()
        {

            if (Input.GetKeyDown(KeyCode.H))
                Healing(10);
            if(Input.GetKeyDown(KeyCode.T))
                TakeDamage(10);
        }
        public void Healing(float addHealth)
        {
            if(isDead) return;
            if(!isDeffPlayer) return;
            health += addHealth;
            if(health > maxHealth)
                health = maxHealth;

            UpdateHealthBar(health,maxHealth);
        }
        protected override void UpdateHealthBar(float currentHealth, float maxHealth)
        {
            UIManager.Instance.UpdateHealth(currentHealth, maxHealth);
        }
        protected override void DeadCharacter()
        {
            isDead = true;
            boxCollider2D.enabled = false;
            playerDead?.Invoke();
        }
        public void RevivalCharacter()
        {
            isDead = false;
            boxCollider2D.enabled = true;
            health = startHealth;
            UpdateHealthBar(health,maxHealth);
        }
    }
}

