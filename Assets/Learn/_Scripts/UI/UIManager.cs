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

        private float health;
        private float maxHealth;
        
        private void Update()
        {
            HeathBar();
        }

        private void HeathBar()
        {
            healthImage.fillAmount = Mathf.Lerp(healthImage.fillAmount, health / maxHealth, 10 * Time.deltaTime);
            healthTMP.text = $"{health}/{maxHealth}";
        }

        public void UpdateHealth(float health, float maxHealth)
        {
            this.health = health;
            this.maxHealth = maxHealth;
        }
    }
}

