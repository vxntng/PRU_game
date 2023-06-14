using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float cameraSpeed = 1f; // T?c ?? di chuy?n c?a camera

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = cameraSpeed * Time.deltaTime; // Tính toán t?c ?? di chuy?n d?a trên th?i gian
        transform.position += new Vector3(moveSpeed, 0f, 0f); // Di chuy?n camera

        // Các x? lý khác trong Update()
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
