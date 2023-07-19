using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public TMP_Text highscore;
    private bool isPaused = false;

    private void Start()
    {
        ScoreManager.LoadHighScore(); 
        highscore.text ="High score: " +ScoreManager.highScore;
    }
    public void OnPauseButtonClicked()
    {
        if (isPaused)
        {
            ResumeGame();
        }
        else
        {
            Pause();
        }
    }
    public GameObject Sample;
    public void Pause()
    {
        Sample.SetActive(true);
        Time.timeScale = 0;
    }

    

    public void ResumeGame()
    {
        Sample.SetActive(false);
        Time.timeScale = 1;
    }
    
    public void ChoiMoi()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void Thoatramenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Thoat()
    {
        Application.Quit();
    }
}
