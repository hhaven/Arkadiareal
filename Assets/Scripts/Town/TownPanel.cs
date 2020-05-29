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
        SceneManager.LoadScene("Menu");
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
        SceneManager.LoadScene("Characters");
    }

    public void ItemsButton()
    {
        SceneManager.LoadScene("StoreItems");

    }

    public void ArmorButton()
    {
        SceneManager.LoadScene("ArmorShop");
    }

    public void WeaponsButton()
    {
        SceneManager.LoadScene("StoreWeapons");
    }

    public void todungeonButton()
    {
        SceneManager.LoadScene("Game");
    }

}
