using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    // Start is called before the first frame update
    public void ButtonReturns()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Options"))
        {
            SceneManager.LoadScene("Menu");
        }
    }


    public void ButtonBack()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Options"))
        {
            SceneManager.LoadScene("Town");
        }
    }


}