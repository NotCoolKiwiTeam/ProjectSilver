using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public void PlayLossAgain()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void BackLoss()
    {
        SceneManager.LoadScene("CustomIntro");
    }

    public void QuitLoss()
    {
        Debug.Log("Application Quitting...");
        Application.Quit();
    }
}
