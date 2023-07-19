using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text highScoreText;
    private const string HighScoreKey = "HighScore";

    private int highScore;

    private void Start()
    {
        LoadHighScore();
      
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

    //public void UpdateHighScoreText()
    //{
    //    highScoreText.text = "High Score: " + highScore.ToString() + "m";
    //}
}
