using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUnit : MonoBehaviour
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
        switch(Random.Range(1, 4))
        {
            case 1:
                unitName = "Plant";
                unitLevel = 1;
                damage = 3;
                abilitydamage = 4;
                maxHP = 11;
                currentHP = 11;
                myImageComponent.sprite = mySecondImage;
                break;
            case 2:
                unitName = "Rock";
                unitLevel = 2;
                damage = 2;
                abilitydamage = 3;
                maxHP = 16;
                currentHP = 16;
                break;
            case 3:
                unitName = "Reaper";
                unitLevel = 3;
                damage = 6;
                abilitydamage = 3;
                maxHP = 4;
                currentHP = 4;
                myImageComponent.sprite = myFirstImage;
                break;
        };
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
