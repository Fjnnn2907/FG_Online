using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbstract : FinMonoBehaviour
{
    public Rigidbody2D rb;

    protected override void LoadCompoment()
    {
        base.LoadCompoment();

        if(rb != null ) return;
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(transform.name + ": LoadRigidbody2D", gameObject);
    }

    protected void MoveParent(Vector2 movement)
    {
        rb.MovePosition(rb.position + movement);
    }
}
