using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Debug.Log("Game Over");
        Application.Quit();
    }

    public void EasyButton()
    {
        SceneManager.LoadScene(2);
    }

    public void NormalButton()
    {
        SceneManager.LoadScene(3);
    }

    public void HardButton()
    {
        SceneManager.LoadScene(4);
    }

    public void ExtremeButton()
    {
        SceneManager.LoadScene(5);
    }
}
