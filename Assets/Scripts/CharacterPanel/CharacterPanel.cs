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
    public Sprite image_character;
    public Text text_name_character;
    public Text text_health;
    public Text text_lvl;
    public Text text_atk;
    public Text text_def;
    public Text text_mdef;
    public Text text_str;
    public Text text_mp;
    public Text text_crit;
    public Text text_eva;




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
        text_health.text = "Health: " + EventSystem.current.currentSelectedGameObject.transform.Find("text_health").GetComponent<Text>().text;
        text_lvl.text = "" + EventSystem.current.currentSelectedGameObject.transform.Find("text_lvl").GetComponent<Text>().text;
        //Extra character information
        text_atk.text = "Attack: " + EventSystem.current.currentSelectedGameObject.transform.Find("text_atk").GetComponent<Text>().text;
        text_def.text = "Defense: " + EventSystem.current.currentSelectedGameObject.transform.Find("text_def").GetComponent<Text>().text;
        text_mdef.text = "Magic Defense: " + EventSystem.current.currentSelectedGameObject.transform.Find("text_mdef").GetComponent<Text>().text;
        text_str.text = "Strange: " + EventSystem.current.currentSelectedGameObject.transform.Find("text_str").GetComponent<Text>().text;
        text_mp.text = "Magic Power: " + EventSystem.current.currentSelectedGameObject.transform.Find("text_mp").GetComponent<Text>().text;
        text_crit.text = "Critical Damage: " + EventSystem.current.currentSelectedGameObject.transform.Find("text_crit").GetComponent<Text>().text;
        text_eva.text = "Evasion: " + EventSystem.current.currentSelectedGameObject.transform.Find("text_eva").GetComponent<Text>().text;
    }

    public void ButtonReturns()
    {
        if (Panel2 == true) {
            Panel2.SetActive(false);
            Panel.SetActive(true);
        }
    }


}
