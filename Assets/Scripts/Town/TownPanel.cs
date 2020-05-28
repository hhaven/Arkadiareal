using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TownPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitButton()
    {
        SceneManager.LoadScene(0);
    }

    public void OptionsButton()
    {
        
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Town"))
        {
            SceneManager.LoadScene("Options");
        }
        
    }

    public void CharactersButton()
    {
        SceneManager.LoadScene(3);
    }

}
