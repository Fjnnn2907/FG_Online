using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FG.Online
{
    public class HealthBase : MonoBehaviour
    {
        [SerializeField] protected float startHealth;
        [SerializeField] protected float maxHealth;

        public float health { get; protected set; }

        protected virtual void Start()
        {
            health = maxHealth;
        }
        public void TakeDamage(float _damage)
        {
            if (health <= 0) return;
            if (_damage <= 0) return;

            health -= _damage;
            if(health <= 0)
                DeadCharacter();

            UpdateHealthBar(health, maxHealth);           
        }
        protected virtual void UpdateHealthBar(float currentHealth, float maxHealth)
        {

        }
        protected virtual void DeadCharacter()
        {

        }
    }

}