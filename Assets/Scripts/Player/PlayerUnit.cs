using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public double damage;
    public double abilitydamage;

    public double maxHP;
    public double currentHP;

    Image myImageComponent;
    public Sprite myFirstImage;
    public Sprite mySecondImage;

    public double maxXP;
    public double currentXP;

    public GameObject playerInfo;

    
    void Start()
    {
        myImageComponent = GetComponent<Image>();
        playerInfo = GameObject.Find("PlayerInfo");
        CharacterDB(); //Create random enemy

    }


    public void CharacterDB()
    {        
        unitName = "Macho";
        unitLevel = playerInfo.GetComponent<PlayerStats>().unitLevel;
        damage = playerInfo.GetComponent<PlayerStats>().damage;
        abilitydamage = playerInfo.GetComponent<PlayerStats>().abilitydamage;
        maxHP = playerInfo.GetComponent<PlayerStats>().maxHP;
        maxXP = playerInfo.GetComponent<PlayerStats>().maxXP;
        currentHP = playerInfo.GetComponent<PlayerStats>().currentHP;
        currentXP = playerInfo.GetComponent<PlayerStats>().currentXP;
        myImageComponent.sprite = myFirstImage;            
    }

    public bool TakeDamage(double dmg)
    {
        currentHP -= dmg;

        if (currentHP <= 0)
        {
            return true;
        }
        else
            return false;
    }

    public void UpdateStats()
    {
        //this.unitLevel = 
    }
}
