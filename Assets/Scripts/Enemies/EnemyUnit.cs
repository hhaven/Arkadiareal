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

    public int boss;

    Image myImageComponent;
    public Sprite plantImage;
    public Sprite rockImage;
    public Sprite penguinImage;
    public Sprite crabImage;
    public Sprite flowerImage;
    public Sprite lizardImage;
    public Sprite bossImage;
    public Sprite bossImage2;
    public Sprite bossImage3;
    public Sprite thingyImage;
    public Sprite scorpionImage;
    public Sprite cubeImage;

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
        if (GameObject.Find("PlayerInfo").GetComponent<PlayerStats>().currentscene == "Game")
        {
            Debug.Log("this works");
            if (GameObject.Find("PlayerInfo").GetComponent<PlayerStats>().isbossbattle)
            {
                boss = 1;
                bossDB();
            }
            else
            {
                EnemyDB1();
            }
        }
        else if(GameObject.Find("PlayerInfo").GetComponent<PlayerStats>().currentscene == "Game1")
        {
            if (GameObject.Find("PlayerInfo").GetComponent<PlayerStats>().isbossbattle)
            {
                boss = 2;
                bossDB();
            }
            else
            {
                EnemyDB2();
            }
        }
        else if(GameObject.Find("PlayerInfo").GetComponent<PlayerStats>().currentscene == "Game2")
        {
            if (GameObject.Find("PlayerInfo").GetComponent<PlayerStats>().isbossbattle)
            {
                boss = 3;
                bossDB();
            }
            else
            {
                EnemyDB3();
            }
        }

    }


    public void EnemyDB1()
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

    public void EnemyDB2()
    {
        switch (Random.Range(1, 4))
        {
            case 1:
                unitName = "Crab";
                unitLevel = 20;
                damage = 60;
                abilitydamage = 4;
                maxHP = 200;
                currentHP = 300;
                XP = 35;
                myImageComponent.sprite = crabImage;
                break;
            case 2:
                unitName = "Flower";
                unitLevel = 25;
                damage = 50;
                abilitydamage = 3;
                maxHP = 16;
                currentHP = 16;
                myImageComponent.sprite = flowerImage;
                XP = 40;
                break;
            case 3:
                unitName = "Lizard";
                unitLevel = 30;
                damage = 150;
                abilitydamage = 3;
                maxHP = 100;
                currentHP = 100;
                XP = 55;
                myImageComponent.sprite = lizardImage;
                break;
        };
    }

    public void EnemyDB3()
    {
        switch (Random.Range(1, 4))
        {
            case 1:
                unitName = "Cube";
                unitLevel = 60;
                damage = 180;
                abilitydamage = 4;
                maxHP = 600;
                currentHP = 600;
                XP = 100;
                myImageComponent.sprite = cubeImage;
                break;
            case 2:
                unitName = "Scorpion";
                unitLevel = 75;
                damage = 150;
                abilitydamage = 3;
                maxHP = 460;
                currentHP = 460;
                myImageComponent.sprite = scorpionImage;
                XP = 120;
                break;
            case 3:
                unitName = "Thingy";
                unitLevel = 90;
                damage = 450;
                abilitydamage = 3;
                maxHP = 300;
                currentHP = 300;
                XP = 200;
                myImageComponent.sprite = thingyImage;
                break;
        };
    }

    public void bossDB()
    {
        switch (boss)
        {
            case 1:
                unitName = "Cow";
                unitLevel = 20;
                damage = 60;
                abilitydamage = 4;
                maxHP = 200;
                currentHP = 300;
                XP = 50;
                myImageComponent.sprite = bossImage;
                break;
            case 2:
                unitName = "Somethingy";
                unitLevel = 50;
                damage = 300;
                abilitydamage = 3;
                maxHP = 1600;
                currentHP = 1600;
                myImageComponent.sprite = bossImage2;
                XP = 100;
                break;
            case 3:
                unitName = "Wow you actually played through this";
                unitLevel = 200;
                damage = 1000;
                abilitydamage = 3;
                maxHP = 10000;
                currentHP = 10000;
                XP = 9999;
                myImageComponent.sprite = bossImage3;
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
