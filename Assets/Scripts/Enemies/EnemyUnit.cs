using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUnit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;

    public double damage;
    public double abilitydamage;

    public double maxHP;
    public double currentHP;

    public int XP;

    Image myImageComponent;
    public Sprite plantImage;
    public Sprite rockImage;
    public Sprite penguinImage;
   /* public Sprite Image;
    public Sprite Image;
    public Sprite Image;
    public Sprite Image;
    public Sprite Image;
    public Sprite Image;
    public Sprite Image;
    public Sprite Image;
    public Sprite Image;
    public Sprite Image;*/


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
                XP = 15;
                myImageComponent.sprite = plantImage;
                break;
            case 2:
                unitName = "Rock";
                unitLevel = 2;
                damage = 2;
                abilitydamage = 3;
                maxHP = 16;
                currentHP = 16;
                myImageComponent.sprite = rockImage;
                XP = 25;
                break;
            case 3:
                unitName = "Penguin";
                unitLevel = 3;
                damage = 6;
                abilitydamage = 3;
                maxHP = 4;
                currentHP = 4;
                XP = 35;
                myImageComponent.sprite = penguinImage;
                break;
        };
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

    public void TakeDamage2(int dmg)
    {
        currentHP -= dmg;

    }



}
