using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text text; 
    public float distanceTraveled;
    public int pointsPerMeter = 100;

    public int score { get; private set; }
    static public int highScore;
    private nhanvatbay player;

    private const string HighScoreKey = "HighScore";

    [SerializeField]private GameManager gameManager;
    private void Awake()
    {
        // T?o singleton instance
        if (instance == null)
        {
            instance = this;
        }
       
    }
    private void Start()
    {
        player = FindObjectOfType<nhanvatbay>();
        LoadHighScore();
        score = 0;
    }

    private void Update()
    {
        if (!player.isDead)
        {
            // C?p nh?t qu�ng ???ng ?i ???c trong m?i khung h�nh
            distanceTraveled += Time.deltaTime;

            // T�nh ?i?m d?a tr�n qu�ng ???ng ?i ???c
            score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);
        }
        else
        {
            if (score > highScore)
            {
                highScore = score;
                SaveHighScore();
             
            }
        }

        // Hi?n th? ?i?m tr�n UI
        text.text = "Score: " + score.ToString() + "m";
    }

    static public void SaveHighScore()
    {
        PlayerPrefs.SetInt(HighScoreKey, highScore);
        PlayerPrefs.Save();
    }

    static public void LoadHighScore()
    {
        if (PlayerPrefs.HasKey(HighScoreKey))
        {
            highScore = PlayerPrefs.GetInt(HighScoreKey);
        }
        else
        {
            highScore = 0;
        }
    }
}
