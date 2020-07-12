using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Slider hpSlider;

    public void SetHUD(PlayerUnit unit)
    {
        hpSlider.maxValue = unit.currentHP;
        hpSlider.value = unit.currentHP;

    }

    public void SetHP(int hp)
    {
        hpSlider.value = hp;
    }

}
