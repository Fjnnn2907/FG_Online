using Fusion;
using UnityEngine;

public class PlayerPhoton : NetworkBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D is missing on " + gameObject.name);
        }
    }

    public override void FixedUpdateNetwork()
    {

        float har = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(har, ver).normalized * speed * Runner.DeltaTime;
        rb.velocity = movement;
    }
}
