﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonReturns()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Town"))
        {
            SceneManager.LoadScene("Options");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Options"))
        {
            SceneManager.LoadScene("Town");
        }
        else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
            SceneManager.LoadScene("Options");
        }
        else SceneManager.LoadScene(0);
    }
}
