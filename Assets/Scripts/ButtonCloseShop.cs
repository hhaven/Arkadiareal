using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCloseShop : MonoBehaviour
{
    public void closeButton()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("StoreItems"))
        {
            SceneManager.LoadScene("Town");
        }else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("ArmorShop"))
        {
            SceneManager.LoadScene("Town");
        }else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("StoreWeapons"))
        {
            SceneManager.LoadScene("Town");
        }
    }
}
