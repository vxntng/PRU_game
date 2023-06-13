using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nhanvatbay : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce;
    
    public Rigidbody2D rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           
           // rb.velocity = new Vector2(rb.velocity.x, jumpForce);
           rb.AddForce( Vector2.up * jumpForce);
        }
    }

    //void FixedUpdate()
    //{
    //    rb.AddForce(new Vector2(0f, -9.8f), ForceMode2D.Force);
    //}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        isJumping = false;
    //    }
    //}
}
