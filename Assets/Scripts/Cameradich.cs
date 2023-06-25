using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameradich : MonoBehaviour
{
    public float cameraSpeed = 1f; // T?c ?? di chuy?n c?a camera
    public bool isCharacterDead = false; // Tr?ng th�i s?ng/ch?t c?a nh�n v?t

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isCharacterDead) // Ki?m tra tr?ng th�i s?ng/ch?t c?a nh�n v?t
        {
            float moveSpeed = cameraSpeed * Time.deltaTime;
            transform.position += new Vector3(moveSpeed, 0f, 0f);
        }


        // C�c x? l� kh�c trong Update()
    }
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //   transform.position += new Vector3(1f + Time.deltaTime, 0f, 0f);
    //}
}
