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

    //private void Pause()
    //{
    //    Time.timeScale = 0f; // T?m d?ng game
    //    isPaused = true;
    //    AudioListener.pause = true; // T?m d?ng âm thanh

    //    // T?m d?ng hi?n th? mesh (n?u có)
    //    Renderer[] renderers = FindObjectsOfType<Renderer>();
    //    foreach (Renderer renderer in renderers)
    //    {
    //        renderer.enabled = false;
    //    }
    //    SceneManager.LoadScene(2);
    //}

    //private void ResumeGame()
    //{
    //    //Time.timeScale = 1f; // Ti?p t?c game
    //    //isPaused = false;
    //    //AudioListener.pause = false; // Ti?p t?c phát âm thanh

    //    //// Hi?n th? l?i mesh (n?u có)
    //    //Renderer[] renderers = FindObjectsOfType<Renderer>();
    //    //foreach (Renderer renderer in renderers)
    //    //{
    //    //    renderer.enabled = true;
    //    //}
    //    //SceneManager.LoadScene(1);

    //    Time.timeScale = 1f; // Ti?p t?c game
    //    AudioListener.pause = false; // Ti?p t?c phát âm thanh

    //    // Hi?n th? l?i mesh (n?u có)
    //    Renderer[] renderers = FindObjectsOfType<Renderer>();
    //    foreach (Renderer renderer in renderers)
    //    {
    //        renderer.enabled = true;
    //    }

    //    SceneManager.LoadScene(1);
    //}
    private void Pause()
    {
        Time.timeScale = 0f; // T?m d?ng game
        isPaused = true;
        AudioListener.pause = true; // T?m d?ng âm thanh

        // T?m d?ng hi?n th? mesh (n?u có)
        Renderer[] renderers = FindObjectsOfType<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            renderer.enabled = false;
        }
        SceneManager.LoadScene(2); // Chuy?n ??n Scene Pause
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f; // Ti?p t?c game
        AudioListener.pause = false; // Ti?p t?c phát âm thanh

        // Hi?n th? l?i mesh (n?u có)
        Renderer[] renderers = FindObjectsOfType<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            renderer.enabled = true;
        }

        SceneManager.LoadScene(1); // Chuy?n ??n Scene Game
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
