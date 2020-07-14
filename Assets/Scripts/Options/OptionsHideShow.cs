using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsHideShow : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    // Start is called before the first frame update
    public void ButtonReturns()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }

        


        
    }

    public void ButtonReturnsDungeon()
    {
        if (Panel2 != null)
        {
            Panel2.SetActive(true);
        }
    }
}
