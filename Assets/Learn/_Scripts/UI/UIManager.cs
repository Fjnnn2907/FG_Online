using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace FG.Online
{
    public class UIManager : Singleton<UIManager>
    {
        [Header("GUI")]
        [SerializeField] private Image healthImage;
        [SerializeField] private TextMeshProUGUI healthTMP;
        [SerializeField] private Image manaImage;
        [SerializeField] private TextMeshProUGUI manaTMP;
        
        private float health;
        private float maxHealth;
        private float mana;
        private float maxMana;
        
        private void Update()
        {
            HeathBar();
            ManaBar();
        }

        private void HeathBar()
        {
            healthImage.fillAmount = Mathf.Lerp(healthImage.fillAmount, health / maxHealth, 10 * Time.deltaTime);
            healthTMP.text = $"{health}/{maxHealth}";
        }
        private void ManaBar()
        {
            manaImage.fillAmount = Mathf.Lerp(manaImage.fillAmount, mana / maxMana, 10 * Time.deltaTime);
            manaTMP.text = $"{mana}/{maxMana}";
        }
        public void UpdateHealth(float health, float maxHealth)
        {
            this.health = health;
            this.maxHealth = maxHealth;
        }
        public void UpdateMana(float mana, float maxMana)
        {
            this.mana = mana;
            this.maxMana = maxMana;
        }
    }
}

