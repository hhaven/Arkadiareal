using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Slider hpSlider;

    public void SetHUD(PlayerUnit unit)
    {
        hpSlider.maxValue = (float)unit.currentHP;
        hpSlider.value = (float)unit.currentHP;

    }

    public void SetHP(float hp)
    {
        hpSlider.value = hp;
    }



}
