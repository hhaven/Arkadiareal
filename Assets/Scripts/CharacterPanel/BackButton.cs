using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void closeButton()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Characters"))
        {
            SceneManager.LoadScene("Town");
        }
    }
}
