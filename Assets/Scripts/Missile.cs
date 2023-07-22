using UnityEngine;

public class Missile : MonoBehaviour
{
    public Transform target; // Tham chi?u ??n Transform c?a nhân v?t

    public float speed = 5f; // T?c ?? di chuy?n c?a tên l?a
    float y;
    Vector3 vitri;
    private void Start()
    {
        y = target.position.y;
        vitri = new Vector3(target.position.x, y, target.position.z);

        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }


    private void Update()
    {

        if (target == null)
            return;

        transform.position = Vector3.MoveTowards(transform.position, vitri, speed * Time.deltaTime);


        if (transform.position == vitri)
        {
            Destroy(gameObject);
        }
    }
}
