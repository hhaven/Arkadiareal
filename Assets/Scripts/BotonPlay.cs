﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonPlay : MonoBehaviour
{
    public void PlayGame()
    {

        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {


        Application.Quit();
    }
}
