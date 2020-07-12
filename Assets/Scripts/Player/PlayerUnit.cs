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

    
    void Start()
    {
        myImageComponent = GetComponent<Image>();
        EnemyDB(); //Create random enemy

    }


    public void EnemyDB()
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
}
