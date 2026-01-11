using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator anim = null;
    private Rigidbody2D rb = null;
    //インスペクターで操作
    public float speed;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //移動
        float horizontal = Input.GetAxis("Horizontal");
        float X_speed = 0.0f;
        float vertical = Input.GetAxis("Vertical");
        float Y_speed = 0.0f;

        if (horizontal > 0.0f)
        {
            transform.localScale = new Vector2(1.0f, 1.0f);
            anim.SetBool("run", true);
            X_speed = speed;
        }
        else if (horizontal < 0)
        {
            transform.localScale = new Vector2(-1.0f, 1.0f);
            anim.SetBool("run", true);
            X_speed = -speed;
        }
        else if (vertical > 0.0f) 
        {
            transform.localScale = new Vector2(1.0f, 1.0f);
            anim.SetBool("run", true);
            Y_speed = speed;
        }
        else if (vertical < 0.0f)
        {
            transform.localScale = new Vector2(-1.0f, 1.0f);
            anim.SetBool("run", true);
            Y_speed = -speed;
        }
        else
        {
            anim.SetBool("run", false);
            X_speed = 0.0f;
            Y_speed = 0.0f;
        }
        rb.velocity = new Vector2 (horizontal, vertical);
    }
}
