using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nhanvatbay : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce;

    public Rigidbody2D rb;
    public float speed;
    public Animator contho;
    private bool isDead = false;

    public Transform groundCheckTransform;
    private bool isGround;
    public LayerMask groundCheckLayerMask;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        contho = GetComponent<Animator>();
        HideGroundCheck();
    }

    void Update()
    {
        if (!isDead) // Ki?m tra xem chu?t có s?ng hay ?ã ch?t
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce);
            }
        }
       
        UpdateGroundedStatus();
    }

    void UpdateGroundedStatus()
    {
        //1
        isGround = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundCheckLayerMask);
        //2
        //   contho.SetBool("isGround", isGround);
        contho.SetBool("isGround", !isGround);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        HitByLaser(collider);
        
    }
    private bool isGroundCheckVisible = true;
    void HideGroundCheck()
    {
        groundCheckTransform.gameObject.SetActive(false);
        isGroundCheckVisible = false;
    }
    void HitByLaser(Collider2D laser)
    {
        isDead = true;
            contho.SetBool("isDead", true);
    }
}
