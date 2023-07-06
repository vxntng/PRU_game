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
        //// C?p nh?t qu�ng ???ng ?i ???c trong m?i khung h�nh
        //distanceTraveled += Time.deltaTime;

        //// T�nh ?i?m d?a tr�n qu�ng ???ng ?i ???c
        //score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);

        //// C?p nh?t UI c?a ?i?m s?
        //text.text = score.ToString() + "m";
        if (!player.isDead)
        {
            // C?p nh?t qu�ng ???ng ?i ???c trong m?i khung h�nh
            distanceTraveled += Time.deltaTime;

            // T�nh ?i?m d?a tr�n qu�ng ???ng ?i ???c
            score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);
        }

        // C?p nh?t UI c?a ?i?m s?
        text.text = score.ToString() + "m";
    }
}





