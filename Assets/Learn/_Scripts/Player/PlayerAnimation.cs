using UnityEngine;

namespace FG.Online
{
    public class PlayerAnimation : FGOnlineMonoBehaviour
    {
        [SerializeField] private Animator anim;
        [SerializeField] private PlayerMovement playerMovement;

        #region Reset
        protected override void LoadCompoment()
        {
            LoadAnimatorEndPlayerMovement();
        }
        private void LoadAnimatorEndPlayerMovement()
        {
            if (anim != null && playerMovement != null) return;
            anim = GetComponent<Animator>();
            playerMovement = GetComponent<PlayerMovement>();
            Debug.Log(transform.name + ": Load Animator End Player Movement", gameObject);
        }
        #endregion
        private void OnEnable()
        {
            PlayerHealth.playerDead += AnimDead;
        }
        private void OnDisable()
        {
            PlayerHealth.playerDead -= AnimDead;
        }
        private void Update()
        {
            UpdateAnimation();
        }
        private void UpdateAnimation()
        {
            if (playerMovement.IsMoving())
            {
                ActiveLayer(FGOnlineTag.RunLayer);
                Vector2 dir = playerMovement.GetDirection();
                anim.SetFloat(FGOnlineTag.AnimX, dir.x);
                anim.SetFloat(FGOnlineTag.AnimY, dir.y);
            }
            else
            {
                ActiveLayer(FGOnlineTag.IdleLayer);
            }
        }
        private void ActiveLayer(string nameLayer)
        {
            for (int i = 0; i < anim.layerCount; i++)
            {
                anim.SetLayerWeight(i, 0);
            }
            anim.SetLayerWeight(anim.GetLayerIndex(nameLayer), 1);
        }
        private void AnimDead()
        {
            if (anim.GetLayerWeight(anim.GetLayerIndex(FGOnlineTag.IdleLayer)) == 1)
                anim.SetBool(FGOnlineTag.AnimDead, true);
        }
        public void AnimRevival()
        {
            ActiveLayer(FGOnlineTag.IdleLayer);
            anim.SetBool(FGOnlineTag.AnimDead, false);
        }
    }

}
