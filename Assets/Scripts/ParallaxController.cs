using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 0.2f;
    private bool bossRaiAppeared = false; // Bi?n ?? ki?m tra BossRai ?ã xu?t hi?n hay ch?a
    private nhanvatbay nhanvatbay;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        nhanvatbay = FindObjectOfType<nhanvatbay>();
    }

    private void Update()
    {
        if (!bossRaiAppeared) // Ki?m tra n?u BossRai ch?a xu?t hi?n
        {
            meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
        }
        if(nhanvatbay.isDead )
        {
            animationSpeed = 0f;
        }
    }

    public void BossRaiAppeared() // Ph??ng th?c ?? ??t bossRaiAppeared thành true
    {
        bossRaiAppeared = true;
    }
}
