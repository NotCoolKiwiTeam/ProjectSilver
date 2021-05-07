using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("CustomIntro");
    }

    public void Quit()
    {
        Debug.Log("Application Quitting...");
        Application.Quit();
    }
}
