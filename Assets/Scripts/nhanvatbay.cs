
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class nhanvatbay : MonoBehaviour
//{
//    public float jumpForce;
//    public float speed;
//    public Rigidbody2D rb;
//    public Animator contho;
//    public bool isDead = false;

//    public Transform groundCheckTransform;
//    private bool isGround;
//    public LayerMask groundCheckLayerMask;

//    private Cameradich cameraScript;
//    public GameObject rocketObject;
//    public GameObject fireObject;

//    public AudioSource footstepsAudio;
//    public AudioSource jetpackAudio;
//    public AudioSource dieAudio;

//    private ScoreManager scoreManager;
//    void Start()
//    {
//        rb = GetComponent<Rigidbody2D>();
//        contho = GetComponent<Animator>();
//        HideGroundCheck();

//        cameraScript = FindObjectOfType<Cameradich>();

//        rocketObject = GameObject.Find("Square");
//        fireObject = GameObject.Find("Fire");
//        fireObject.SetActive(false);
//    }

//    void Update()
//    {
//        bool jetpackActive = Input.GetButton("Fire1");
//        jetpackActive = jetpackActive && !isDead;

//        if (!isDead)
//        {
//            if (Input.GetKey(KeyCode.Space))
//            {
//                rb.AddForce(Vector2.up * jumpForce);
//            }
//        }
//        else
//        {
//            // rb.velocity = Vector2.zero;
//        }

//        UpdateGroundedStatus();
//        AdjustFootstepsAndJetpackSound(jetpackActive);
//        UpdateFireObject();
//    }

//    void UpdateGroundedStatus()
//    {
//        isGround = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundCheckLayerMask);
//        contho.SetBool("isGround", !isGround);
//    }

//    void OnTriggerEnter2D(Collider2D collider)
//    {
//        HitByLaser(collider);
//    }

//    void HideGroundCheck()
//    {
//        groundCheckTransform.gameObject.SetActive(false);
//    }

//    void HitByLaser(Collider2D laser)
//    {
//      //  dieAudio.enabled = isDead == true;
//        isDead = true;
//        contho.SetBool("isDead", true);
//        cameraScript.isCharacterDead = true;
//        dieAudio.Play(); // Phát âm thanh dieAudio

//        rocketObject.SetActive(false);
//    }

//    void AdjustFootstepsAndJetpackSound(bool jetpackActive)
//    {
//        footstepsAudio.enabled = isDead == false && isGround;
//        jetpackAudio.enabled = isDead == false && !isGround;

//        if (jetpackActive)
//        {
//            jetpackAudio.volume = 1.0f;
//        }
//        else
//        {
//            footstepsAudio.volume = 0.5f;
//        }


//    }

//    void UpdateFireObject()
//    {
//        if (isGround)
//        {
//            fireObject.SetActive(false); // ?n GameObject l?a khi nhân v?t ?ang ? trên sàn
//        }
//        else
//        {
//            fireObject.SetActive(true); // Hi?n th? GameObject l?a khi nhân v?t ?ang bay
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nhanvatbay : MonoBehaviour
{
    public float jumpForce;
    public float speed;
    public Rigidbody2D rb;
    public Animator contho;
    public bool isDead = false;

    public Transform groundCheckTransform;
    private bool isGround;
    public LayerMask groundCheckLayerMask;

    private Cameradich cameraScript;
    public GameObject rocketObject;
    public GameObject fireObject;

    public AudioSource footstepsAudio;
    public AudioSource jetpackAudio;
    public AudioSource dieAudio;

    private Gameover gameOver;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        contho = GetComponent<Animator>();
        HideGroundCheck();

        cameraScript = FindObjectOfType<Cameradich>();

        rocketObject = GameObject.Find("Square");
        fireObject = GameObject.Find("Fire");
        fireObject.SetActive(false);

        gameOver = FindObjectOfType<Gameover>();
    }

    void Update()
    {
        bool jetpackActive = Input.GetButton("Fire1");
        jetpackActive = jetpackActive && !isDead;

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
        UpdateFireObject();
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
        // dieAudio.enabled = isDead == true;
        isDead = true;
        contho.SetBool("isDead", true);
        cameraScript.isCharacterDead = true;
        dieAudio.Play(); // Phát âm thanh dieAudio

        rocketObject.SetActive(false);

        gameOver.ShowGameOverPanel();
    }

    void AdjustFootstepsAndJetpackSound(bool jetpackActive)
    {
        footstepsAudio.enabled = isDead == false && isGround;
        jetpackAudio.enabled = isDead == false && !isGround;

        if (jetpackActive)
        {
            jetpackAudio.volume = 1.0f;
        }
        else
        {
            footstepsAudio.volume = 0.5f;
        }
    }

    void UpdateFireObject()
    {
        if (isGround)
        {
            fireObject.SetActive(false); // ?n GameObject l?a khi nhân v?t ?ang trên sàn
        }
        else
        {
            fireObject.SetActive(true); // Hi?n th? GameObject l?a khi nhân v?t ?ang bay
        }
    }
}

