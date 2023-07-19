//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Gameover : MonoBehaviour
//{
//    public GameObject GameOver;
//    public TMP_Text scoreText;
//    private ScoreManager scoreManager;

//    // Start is called before the first frame update
//    public void ShowGameOverPanel()
//    {
//        // Hi?n th? panel game over
//        GameOver.SetActive(true);

//        // Hi?n th? s? ?i?m
//        scoreText.text = "Score " +
//            scoreManager.score.ToString() + " m";
//    }

//    public void RestartGame()
//    {
//        // T?i l?i scene hi?n t?i
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//    }

//    public void GoToMenu()
//    {
//        // Quay l?i scene menu 
//        SceneManager.LoadScene(0);
//    }
//}
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public GameObject GameOver;
    public TMP_Text scoreText;
    private ScoreManager scoreManager;

    public void SetScoreManager(ScoreManager manager)
    {
        scoreManager = manager;
    }

    // Start is called before the first frame update
    public void ShowGameOverPanel()
    {
        // Hi?n th? panel game over
        GameOver.SetActive(true);

        // Hi?n th? s? ?i?m
        if (scoreManager != null)
        {
            scoreText.text = "Score " + scoreManager.score.ToString() + " m";
        }
        else
        {
            scoreText.text = "Score: N/A";
        }
    }

    public void RestartGame()
    {
        // T?i l?i scene hi?n t?i
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMenu()
    {
        // Quay l?i scene menu
        SceneManager.LoadScene(0);
    }
}
