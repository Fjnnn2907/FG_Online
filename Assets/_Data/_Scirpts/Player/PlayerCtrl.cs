using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected float speed = 5;
    [SerializeField] protected Joystick joystick;
    private void FixedUpdate()
    {
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            CheckJoytick();
        }
        else
        {
            CheckInput();
        }
    }
    public void SetVeloctiy(float x, float y)
    {
        rb.MovePosition(rb.position + new Vector2(x, y).normalized * speed * Time.fixedDeltaTime);
    }
    public void CheckInput()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        SetVeloctiy(hor, ver);
    }
    public void CheckJoytick()
    {
        float hor = joystick.Horizontal;
        float ver = joystick.Vertical;

        SetVeloctiy(hor, ver);
    }
}
