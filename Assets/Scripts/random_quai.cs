using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_quai : MonoBehaviour
{
    public float moveSpeed = 5f; // T?c ?? di chuy?n tr�n m?t ??t
    private Rigidbody2D rigidbody2D; // Tham chi?u ??n Rigidbody2D c?a con qu�i
    private int moveDirection = 1; // H??ng di chuy?n: 1 - Ph?i, -1 - Tr�i

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ??o ng??c h??ng di chuy?n khi ??n r�a m�n h�nh
        if (transform.position.x >= 10f)
        {
            moveDirection = -1;
        }
        else if (transform.position.x <= -10f)
        {
            moveDirection = 1;
        }

        // Di chuy?n theo h??ng v� t?c ?? ?� ch? ??nh
        Vector2 movement = new Vector2(moveDirection, 0f);
        rigidbody2D.velocity = movement * moveSpeed;
    }
}
