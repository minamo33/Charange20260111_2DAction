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
    void FixedUpdate()
    {
        //移動
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal, vertical) * speed;

        anim.SetFloat("horizontal", Mathf.Abs(horizontal));
        anim.SetFloat("vertical", Mathf.Abs(vertical));
        //向き変更
        if (horizontal > 0) transform.localScale = new Vector3(1, 1, 1);
        else if(horizontal < 0) transform.localScale = new Vector3(-1, 1, 1);

    }
}
