using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    public string unitName;
    public int unitLevel;

    public double damage;
    public double abilitydamage;

    public double maxHP;
    public double currentHP;

    public double defense;

    public double maxXP;
    public double currentXP;

    public string currentscene;
    public bool isbossbattle;
    public int bossdefeated;

    private static GameObject instance;
    void Awake()
    {
        if(!PlayerPrefs.HasKey("Level"))
        {

            CharacterDB();
        }
        else
        {
            LoadCharacter();
        }
        DontDestroyOnLoad(gameObject);
        if (instance == null)
            instance = gameObject;
        else
            Destroy(gameObject);
        


    }

    public void CharacterDB()
    {
        unitLevel = 10;
        damage = 55;
        abilitydamage = 5;
        maxHP = 30;
        defense = 1;
        currentHP = 30;
        currentXP = 99;
        maxXP = 100;
    }

    public void LoadCharacter()
    {
        unitLevel = PlayerPrefs.GetInt("Level");
        damage = PlayerPrefs.GetInt("damage");
        abilitydamage = 5;
        maxHP = PlayerPrefs.GetInt("maxHP");
        currentHP = PlayerPrefs.GetInt("currentHP");
        currentXP = PlayerPrefs.GetInt("currentXP");
        maxXP = PlayerPrefs.GetInt("maxXP");
    }

    // Update is called once per frame
    void Update()
    {
        SetScene();
    }

    public void LevelUp()
    {
        unitLevel += 1;
        damage = Math.Ceiling((damage+1) + damage*0.15);
        abilitydamage = Math.Ceiling((damage+3) + damage*0.2);
        maxHP = Math.Ceiling((maxHP+1) + unitLevel*0.10);
        defense = Math.Ceiling((defense + 5));
        currentHP = maxHP;
        currentXP = 0;
        maxXP = Math.Ceiling((maxXP+10) +maxXP*0.4);
    }

    public void SetScene()
    {
        currentscene = SceneManager.GetActiveScene().name;
    }
}
