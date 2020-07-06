using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public GameObject EnterBTM;
    public GameObject intro;

    /*private void Update(){

        
        if (intro.GetComponent<AnimatedText>().getLineaActual() == intro.GetComponent<AnimatedText>().getLastLine() && intro.GetComponent<AnimatedText>().getCheckNext() && Input.GetKeyDown(KeyCode.Return)){

            EnterBTM.SetActive(false);
            StartCoroutine(LoadScene());
        }
    }*/


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
