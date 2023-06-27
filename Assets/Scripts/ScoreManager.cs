using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    private ScoreUI scoreUI;

    // Update is called once per frame
    public float distanceTraveled;
    public int pointsPerMeter = 100;

    private int score;
    void Start()
    {
    //    scoreUI = FindObjectOfType<ScoreUI>();
    }
    private void Update()
    {
        // C?p nh?t quãng ???ng ?i ???c trong m?i khung hình
        distanceTraveled += Time.deltaTime;

        // Tính ?i?m d?a trên quãng ???ng ?i ???c
        score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);
    }

    private void UpdateScoreUI()
    {
        scoreUI.UpdateScore(score);
    }
}
