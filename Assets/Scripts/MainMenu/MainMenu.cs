using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void OptionsGame()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
            SceneManager.LoadScene("Options");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Options"))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void QuitGame()
    {


        Application.Quit();
    }
}
