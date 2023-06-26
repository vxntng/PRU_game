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

    private Collider2D laserCollider;
    private Collider2D groundCollider;
    private Collider2D raserCollider;

    private Cameradich cameraScript; // Tham chi?u t?i script "Cameradich"

    public GameObject rocketObject;
    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //    contho = GetComponent<Animator>();
    //    HideGroundCheck();

    //    cameraScript = FindObjectOfType<Cameradich>();

    //    rocketObject = GameObject.Find("Rocket");
    //}

    //void Update()
    //{
    //    if (!isDead) // Ki?m tra xem chu?t có s?ng hay ?ã ch?t
    //    {
    //        if (Input.GetKey(KeyCode.Space))
    //        {
    //            rb.AddForce(Vector2.up * jumpForce);
    //        }
    //        //AudioSource laserZap = laserCollider.gameObject.GetComponent<AudioSource>();
    //        //laserZap.Play();
    //    }
    //    else
    //    {
    //        rb.AddForce(Vector2.zero);
    //    }

    //    UpdateGroundedStatus();
    //}

    //void UpdateGroundedStatus()
    //{
    //    //1
    //    isGround = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundCheckLayerMask);
    //    //2
    //    //   contho.SetBool("isGround", isGround);
    //    contho.SetBool("isGround", !isGround);
    //}

    //void OnTriggerEnter2D(Collider2D collider)

    //{
    //    HitByLaser(collider);

    //}
    //private bool isGroundCheckVisible = true;
    //void HideGroundCheck()
    //{
    //    groundCheckTransform.gameObject.SetActive(false);
    //    isGroundCheckVisible = false;
    //}


    //void HitByLaser(Collider2D laser)
    //{
    //    isDead = true;
    //    contho.SetBool("isDead", true);
    //    cameraScript.isCharacterDead = true; // ??t tr?ng thái s?ng/ch?t c?a nhân v?t trong script "Cameradich" thành true


    //}

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        contho = GetComponent<Animator>();
        HideGroundCheck();

        cameraScript = FindObjectOfType<Cameradich>();

        rocketObject = GameObject.Find("Square");
    }

    void Update()
    {
        if (!isDead)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce);
            }
        }
        else
        {
           // rb.velocity = Vector2.zero;
        }

        UpdateGroundedStatus();
    }

    void UpdateGroundedStatus()
    {
        isGround = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundCheckLayerMask);
        contho.SetBool("isGround", !isGround);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        HitByLaser(collider);
    }

    void HideGroundCheck()
    {
        groundCheckTransform.gameObject.SetActive(false);
    }

    void HitByLaser(Collider2D laser)
    {
        isDead = true;
        contho.SetBool("isDead", true);
        cameraScript.isCharacterDead = true;

        rocketObject.SetActive(false);
    }
}
