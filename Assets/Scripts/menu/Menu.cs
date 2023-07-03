using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    private bool isPaused = false;

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
    private void Pause()
    {
        Time.timeScale = 0f; // T?m d?ng game
        isPaused = true;
        // Hi?n th? giao di?n t?m d?ng game (n?u c?n)
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f; // Ti?p t?c game
        isPaused = false;
        // ?n giao di?n t?m d?ng game (n?u c?n)
    }
    public void ChoiMoi()
    {
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
