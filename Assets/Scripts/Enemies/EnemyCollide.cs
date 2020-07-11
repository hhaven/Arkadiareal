using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollide : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Player;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (Panel != null)
        {
            
            Panel.SetActive(false);
            Panel2.SetActive(true);
            
        }

        Destroy(this.gameObject);
        
        //Player.SetActive(false);
    }

   

}
