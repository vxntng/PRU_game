

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

    public GameObject gameOverScene;

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

        // G�n gi� tr? cho bi?n dieAudio th�ng qua GetComponent
        dieAudio = GetComponent<AudioSource>();

        // G�n gi� tr? cho bi?n footstepsAudio v� jetpackAudio th�ng qua GetComponent
        footstepsAudio = GetComponent<AudioSource>();
        jetpackAudio = GetComponent<AudioSource>();

        // G�n gi� tr? cho bi?n gameOver th�ng qua FindObjectOfType
        gameOver = FindObjectOfType<Gameover>();

    }
    void Update()
    {
        Debug.Log(Time.timeScale);
        bool jetpackActive = Input.GetButton("Fire1");
        jetpackActive = jetpackActive && !isDead;

        if (!isDead)
        {
            //if (Input.GetKey(KeyCode.Space))
            //{
            //    rb.AddForce(Vector2.up * jumpForce);
            //}
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                // N?u ng??i d�ng ch?m v�o m�n h�nh (b?t k? n?i ch?m)
                if (touch.phase == TouchPhase.Began)
                {
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                }
            }
        }
        else
        {
          
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
        if (collider.CompareTag("Laser")) // Ki?m tra xem collider c� l� lo?i "Laser" kh�ng
        {
            HitByLaser(collider);

        }
    }

    void HideGroundCheck()
    {
        groundCheckTransform.gameObject.SetActive(false);
    }

   
    void HitByLaser(Collider2D laser)
    {
        if (laser != null)
        {
          
            Die();
        }
        else
        {
            Debug.LogWarning("Laser collider is null.");
        }
    }
    void Die()
    {
        
        isDead = true;
        contho.SetBool("isDead", true);
        cameraScript.isCharacterDead = true;
        dieAudio.Play(); // Ph�t �m thanh dieAudio

        Invoke("changeToGameOver",2f);
    }
    void tenlua()
    {

        isDead = true;
        contho.SetBool("isDead", true);
        cameraScript.isCharacterDead = true;
        dieAudio.Play(); // Ph�t �m thanh dieAudio

        Invoke("changeToGameOver", 2f);
    }
    void changeToGameOver()
    {
        gameOverScene.SetActive(true);
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
            fireObject.SetActive(false); // ?n GameObject l?a khi nh�n v?t ?ang tr�n s�n
        }
        else
        {
            fireObject.SetActive(true); // Hi?n th? GameObject l?a khi nh�n v?t ?ang bay
        }
    }
}

