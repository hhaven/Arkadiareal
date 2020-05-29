using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsHideShow : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    public void ButtonReturns()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }


        
    }
}
