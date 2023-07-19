//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;

//public class ScoreManager : MonoBehaviour
//{
//    public TMP_Text text;
//    public float distanceTraveled;
//    public int pointsPerMeter = 100;

//    public int score;
//    private nhanvatbay player;

//    private Gameover gameover;

//    private const string ScoreKey = "Score";

//    void Start()
//    {
//        player = FindObjectOfType<nhanvatbay>();
//        LoadScore();
//    }

//    void Update()
//    {
//        if (!player.isDead)
//        {
//            // C?p nh?t quãng ???ng ?i ???c trong m?i khung hình
//            distanceTraveled += Time.deltaTime;

//            // Tính ?i?m d?a trên quãng ???ng ?i ???c
//            score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);
//        }
//        else
//        {
//            //ShowGameOverPanel();
//        }

//        // C?p nh?t UI c?a ?i?m s?
//        text.text = score.ToString() + "m";

//        // L?u s? ?i?m
//        SaveScore();
//    }

//    void SaveScore()
//    {
//        PlayerPrefs.SetInt(ScoreKey, score);
//        PlayerPrefs.Save();
//    }

//    void LoadScore()
//    {
//        if (PlayerPrefs.HasKey(ScoreKey))
//        {
//            score = PlayerPrefs.GetInt(ScoreKey);
//        }
//        else
//        {
//            score = 0;
//        }
//    }
//}




//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;

//public class ScoreManager : MonoBehaviour
//{
//    public TMP_Text text;
//    public float distanceTraveled;
//    public int pointsPerMeter = 100;

//    public int score;
//    private int highScore;
//    private nhanvatbay player;

//    private const string HighScoreKey = "HighScore";

//    private GameManager gameManager;

//    private void Start()
//    {
//        player = FindObjectOfType<nhanvatbay>();
//        gameManager = FindObjectOfType<GameManager>();
//        LoadHighScore();
//        score = 0;
//    }

//    private void Update()
//    {
//        if (!player.isDead)
//        {
//            // C?p nh?t quãng ???ng ?i ???c trong m?i khung hình
//            distanceTraveled += Time.deltaTime;

//            // Tính ?i?m d?a trên quãng ???ng ?i ???c
//            score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);
//        }
//        else
//        {
//            if (score > highScore)
//            {
//                highScore = score;
//                SaveHighScore();
//                gameManager.UpdateHighScoreText();
//            }
//        }

//        // Hi?n th? ?i?m trên UI
//        text.text = "Score: " + score.ToString() + "m";
//    }

//    private void SaveHighScore()
//    {
//        PlayerPrefs.SetInt(HighScoreKey, highScore);
//        PlayerPrefs.Save();
//    }

//    private void LoadHighScore()
//    {
//        if (PlayerPrefs.HasKey(HighScoreKey))
//        {
//            highScore = PlayerPrefs.GetInt(HighScoreKey);
//        }
//        else
//        {
//            highScore = 0;
//        }
//    }
//}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text text;
    public float distanceTraveled;
    public int pointsPerMeter = 100;

    public int score { get; private set; }
    private int highScore;
    private nhanvatbay player;

    private const string HighScoreKey = "HighScore";

    private GameManager gameManager;

    private void Start()
    {
        player = FindObjectOfType<nhanvatbay>();
        gameManager = FindObjectOfType<GameManager>();
        LoadHighScore();
        score = 0;
    }

    private void Update()
    {
        if (!player.isDead)
        {
            // C?p nh?t quãng ???ng ?i ???c trong m?i khung hình
            distanceTraveled += Time.deltaTime;

            // Tính ?i?m d?a trên quãng ???ng ?i ???c
            score = Mathf.RoundToInt(distanceTraveled * pointsPerMeter);
        }
        else
        {
            if (score > highScore)
            {
                highScore = score;
                SaveHighScore();
                gameManager.UpdateHighScoreText();
            }
        }

        // Hi?n th? ?i?m trên UI
        text.text = "Score: " + score.ToString() + "m";
    }

    private void SaveHighScore()
    {
        PlayerPrefs.SetInt(HighScoreKey, highScore);
        PlayerPrefs.Save();
    }

    private void LoadHighScore()
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
