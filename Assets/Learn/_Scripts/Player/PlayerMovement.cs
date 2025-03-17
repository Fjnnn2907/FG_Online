using UnityEngine;

namespace FG.Online
{
    public class PlayerMovement : FGOnlineMonoBehaviour
    {
        [SerializeField] private float speed = 4;

        [SerializeField] private Rigidbody2D rb;
        private Vector2 input;
        private Vector2 direction;

        #region Reset
        protected override void LoadCompoment()
        {
            LoadRigidbody2D();
        }
        private void LoadRigidbody2D()
        {
            if (rb != null) return;

            rb = GetComponent<Rigidbody2D>();
            Debug.Log(transform.name + ": LoadRigidbody2D", gameObject);
        }
        #endregion

        private void Update()
        {
            CheckInput();
        }
        private void FixedUpdate()
        {
            Movement();
            MoveDirection();
        }
        private void Movement()
        {
            rb.MovePosition(rb.position + direction.normalized * speed * Time.fixedDeltaTime);
        }
        public bool IsMoving()
        {
            return direction.magnitude > 0;
        }
        public Vector2 GetDirection()
        {
            return direction;
        }
        private void CheckInput()
        {
            input = new Vector2(Input.GetAxisRaw(FGOnlineTag.HorizontalAxis), Input.GetAxisRaw(FGOnlineTag.VerticalAxis));
        }
        private void MoveDirection()
        {
            // X
            if (input.x > .1f)
                direction.x = 1;
            else if (input.x < 0)
                direction.x = -1;
            else
                direction.x = 0;
            // Y
            if (input.y > .1f)
                direction.y = 1;
            else if (input.y < 0)
                direction.y = -1;
            else
                direction.y = 0;
        }
    }
}
