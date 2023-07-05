using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    private ScoreUI scoreUI;

    public float distanceTraveled;
    public int pointsPerMeter = 100;

    private int score;

    void Start()
    {
        scoreUI = FindObjectOfType<ScoreUI>();
        score = 0;
    }

    void Update()
    {
        // C?p nh?t quãng ???ng ?i ???c trong m?i khung hình
        distanceTraveled += Time.deltaTime;

        // Tính ?i?m d?a trên quãng ???ng ?i ???c
        score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);

        // C?p nh?t UI c?a ?i?m s?
        if (scoreUI != null)
        {
            scoreUI.UpdateScore(score);
        }
    }
}
