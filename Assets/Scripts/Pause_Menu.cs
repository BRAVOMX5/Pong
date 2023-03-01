using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause_Menu : MonoBehaviour
{
    public GameObject PauseMenu;
    private bool GamePaused = false;
    public AudioSource Music;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        GamePaused = true;
        Time.timeScale = 0f;     
        Music.Pause();
        PauseMenu.SetActive(true);
    }

    public void Resume()
    {
        GamePaused = false;
        Time.timeScale = 1f;
        Music.Play();
        PauseMenu.SetActive(false);
    }

    public void MainMenu()
    {
        GamePaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("Game Over");
        Application.Quit();
    }
}
