using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nhanvatbay : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpForce;
    
    public Rigidbody2D rb;
    public float speed;

    private bool isDead = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        else
        {

        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        HitByLaser(collider);
    }

    void HitByLaser(Collider2D laser)
    {
        isDead = true;
    }
}
