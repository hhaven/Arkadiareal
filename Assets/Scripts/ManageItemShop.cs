using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageItemShop : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;

    public void OpenPanel()
    {
        
        if (Panel != null)
        {
            Panel2.SetActive(false);
            Panel.SetActive(true);
        }
    }
}
