using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public GameObject playerInfo;
    public void actualSave()
    {
        playerInfo = GameObject.Find("PlayerInfo");
        PlayerPrefs.SetInt("maxHP", Convert.ToInt32(playerInfo.GetComponent<PlayerStats>().maxHP));
        PlayerPrefs.SetInt("currentHP", Convert.ToInt32(playerInfo.GetComponent<PlayerStats>().currentHP));
        PlayerPrefs.SetInt("damage", Convert.ToInt32(playerInfo.GetComponent<PlayerStats>().damage));
        PlayerPrefs.SetInt("Level", Convert.ToInt32(playerInfo.GetComponent<PlayerStats>().unitLevel));
        PlayerPrefs.SetInt("currentXP", Convert.ToInt32(playerInfo.GetComponent<PlayerStats>().currentXP));
        PlayerPrefs.SetInt("maxXP", Convert.ToInt32(playerInfo.GetComponent<PlayerStats>().maxXP));


    }

    /*
     *  unitLevel = 10; -
        damage = 55; -
        abilitydamage = 5;
        maxHP = 30; -
        currentHP = 30;
        currentXP = 99;-
        maxXP = 100;
     */

    public void actualLoad()
    {
        Debug.Log("your saved xp is " + PlayerPrefs.GetInt("currentXP") + "\n your level is " + PlayerPrefs.GetInt("Level"));
    }
}
