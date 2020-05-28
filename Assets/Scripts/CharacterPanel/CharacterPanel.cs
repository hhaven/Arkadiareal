using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Transactions;
using UnityEngine.EventSystems;

public class CharacterPanel : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel2;
    public Text text_name_character;
    public Sprite image_character;



    public void ButtonCharacter()
    {
        if (Panel2 != null)
        {
            Panel.SetActive(false);
            Panel2.SetActive(true);
        }
    }


    public void CharacterInfo()
    {
        text_name_character.text = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text;
        image_character = EventSystem.current.currentSelectedGameObject.transform.Find("Image").GetComponent<Image>().sprite;
        GameObject.Find("image_character").GetComponent<Image>().sprite = image_character;
    }

    


}
