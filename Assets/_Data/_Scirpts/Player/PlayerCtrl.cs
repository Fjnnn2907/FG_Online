using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [Header("Physic")]
    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected float speed = 5;
    [SerializeField] protected Vector2 movement;
    [SerializeField] protected Joystick joystick;
    [Header("Animation")]
    [SerializeField] protected Animator anim;
    [Header("Sprite Renderer")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    private void Reset()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        CheckInput();
    }
    public void SetVeloctiy(float x, float y)
    {
        movement = new Vector2(x, y).normalized * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
    public void CheckInput()
    {
        float hor = joystick.Horizontal != 0 ? joystick.Horizontal : Input.GetAxisRaw("Horizontal");
        float ver = joystick.Vertical != 0 ? joystick.Vertical : Input.GetAxisRaw("Vertical");

        SetVeloctiy(hor, ver);
        Animation(hor, ver);
    }
    public void Animation(float x, float y)
    {
        
        if (movement != Vector2.zero)
        {
            anim.Play("Move");
            anim.SetFloat("xVelocity", x);
            anim.SetFloat("yVelocity", y);
            if (x != 0)
                spriteRenderer.flipX = x < 0;
        }
        else
            anim.Play("Idle");
    }
}
