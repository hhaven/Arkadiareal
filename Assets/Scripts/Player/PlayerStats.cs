using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public string unitName;
    public int unitLevel;

    public double damage;
    public double abilitydamage;

    public double maxHP;
    public double currentHP;

    public double maxXP;
    public double currentXP;
    // Start is called before the first frame update
    void Awake()
    {
        CharacterDB();
    }

    public void CharacterDB()
    {
        unitLevel = 10;
        damage = 55;
        abilitydamage = 5;
        maxHP = 30;
        currentHP = 30;
        currentXP = 99;
        maxXP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentXP >= maxXP)
        {
            //LevelUp();
        }
    }

    public void LevelUp()
    {
        unitLevel += 1;
        damage = Math.Ceiling((damage+1) + damage*0.15);
        abilitydamage = Math.Ceiling((damage+3) + damage*0.2);
        maxHP = Math.Ceiling((maxHP+1) + unitLevel*0.10);
        currentHP = maxHP;
        currentXP = 0;
        maxXP = Math.Ceiling((maxXP+10) +maxXP*0.4);
    }
}
