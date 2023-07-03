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
    public bool isDead = false;

    public Transform groundCheckTransform;
    private bool isGround;
    public LayerMask groundCheckLayerMask;

    private Collider2D laserCollider;
    private Collider2D groundCollider;
    private Collider2D raserCollider;

    private Cameradich cameraScript; // Tham chi?u t?i script "Cameradich"

    public GameObject rocketObject;

    public AudioSource footstepsAudio;
    public AudioSource jetpackAudio;
    

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
        bool jetpackActive = Input.GetButton("Fire1");
        jetpackActive = jetpackActive && !isDead;

        //if (jetpackActive)
        //{
        //    playerRigidbody.AddForce(new Vector2(0, jetpackForce));
        //}

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
        AdjustFootstepsAndJetpackSound(jetpackActive);
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

    void AdjustFootstepsAndJetpackSound(bool jetpackActive)
    {
        footstepsAudio.enabled = isDead==false && isGround;
        jetpackAudio.enabled = isDead==false && !isGround;
       
        if (jetpackActive)
        {
            jetpackAudio.volume = 1.0f;
        }
        else
        {
            jetpackAudio.volume = 0.5f;
        }
    }
}
