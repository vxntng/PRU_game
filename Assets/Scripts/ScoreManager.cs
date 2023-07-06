using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text text;
    public float distanceTraveled;
    public int pointsPerMeter = 100;
    
    private int score;
    private nhanvatbay player;

    void Start()
    {
        score = 0;
        player = FindObjectOfType<nhanvatbay>();
    }

    void Update()
    {
        //// C?p nh?t quãng ???ng ?i ???c trong m?i khung hình
        //distanceTraveled += Time.deltaTime;

        //// Tính ?i?m d?a trên quãng ???ng ?i ???c
        //score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);

        //// C?p nh?t UI c?a ?i?m s?
        //text.text = score.ToString() + "m";
        if (!player.isDead)
        {
            // C?p nh?t quãng ???ng ?i ???c trong m?i khung hình
            distanceTraveled += Time.deltaTime;

            // Tính ?i?m d?a trên quãng ???ng ?i ???c
            score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);
        }

        // C?p nh?t UI c?a ?i?m s?
        text.text = score.ToString() + "m";
    }
}





