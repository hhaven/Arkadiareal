using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {

        SceneManager.LoadScene("Town");
    }

    public void OptionsGame()
    {
       
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
            SceneManager.LoadScene("Options");
        }
       
    }

    public void QuitGame()
    {


        Application.Quit();
    }
}
