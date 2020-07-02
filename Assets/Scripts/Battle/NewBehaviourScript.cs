using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    // Start is called before the first frame update
    public void GameReturn()
    {

        if (Panel != null)
        {
            Panel.SetActive(false);
            Panel2.SetActive(true);
        }

    }
    /*
       ░░░░░░░░░░░░░░░░░░░░░░░░░░░
       ░█▀▀░█▀█░█▀░▀░█░░▀░▀█▀░█▀█░
       ░█▀░░█▀█░█░░█░█░░█░░█░░█░█░
       ░▀░░░▀░▀░▀▀░▀░▀▀░▀░░▀░░▀▀▀░
       ░░░░░░░░░░░░░░░░░░░░░░░░░░░
     */
}
