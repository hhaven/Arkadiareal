using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUnit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public int damage;
    public int abilitydamage;

    public int maxHP;
    public int currentHP;

    Image myImageComponent;
    public Sprite myFirstImage;
    public Sprite mySecondImage;

    public GameObject playerInfo;

    
    void Start()
    {
        myImageComponent = GetComponent<Image>();
        CharacterDB(); //Create random enemy

    }


    public void CharacterDB()
    {        
        unitName = "Macho";
        unitLevel = 1;
        damage = 5;
        abilitydamage = 5;
        maxHP = 30;
        currentHP = 30;
        myImageComponent.sprite = myFirstImage;            
    }

    public bool TakeDamage(int dmg)
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
