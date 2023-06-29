using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class laser : MonoBehaviour
{
    public Sprite laserOnSprite;
    public Sprite laserOffSprite;
    //2
    public float toggleInterval = 0.4f;
    public float rotationSpeed = 0.0f;
    //3
    private bool isLaserOn = true;
    private float timeUntilNextToggle;
    //4
    private Collider2D laserCollider;
    private SpriteRenderer laserRenderer;

    public float minSize = 0.5f;
    public float maxSize = 1.5f;
    void Start()
    {
        timeUntilNextToggle = toggleInterval;
        //2
        laserCollider = gameObject.GetComponent<Collider2D>();
        laserRenderer = gameObject.GetComponent<SpriteRenderer>();
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1f);
    }

    private void Update()
    {
        timeUntilNextToggle -= Time.deltaTime;
        //2
        if (timeUntilNextToggle <= 0)
        {
            //3
            isLaserOn = !isLaserOn;
            //4
            laserCollider.enabled = isLaserOn;
            //5
            if (isLaserOn)
            {
                laserRenderer.sprite = laserOnSprite;
            }
            else
            {
                laserRenderer.sprite = laserOffSprite;
            }
            //6
            timeUntilNextToggle = toggleInterval;
        }
        //7
        transform.RotateAround(transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
    }


}
