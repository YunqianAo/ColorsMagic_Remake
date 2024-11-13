using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    float baseDamage = 50;
    float totalDamage = 0;
    public Text textDamage;
    
    ColorPrecision colorPrecision;

    private void Start()
    {
        colorPrecision = GameObject.FindObjectOfType<ColorPrecision>();
    }

    private float CalculateDamage() 
    {
        float precision = colorPrecision.GetPrecision();
        ScoreManager.instance.SetScore((int)precision);

        float damage = 0;
        switch (precision) 
        {
            case < 50:
                damage = 0;
                break;
            case < 60:
                damage = baseDamage - (baseDamage * 0.1f);
                break;
            case < 80:
                damage = baseDamage + (baseDamage * 0.15f);
                baseDamage += 5;
                break;
            case < 98:
                damage = baseDamage + (baseDamage * 0.35f);
                baseDamage += 10;
                break;    
            case <= 100:
                damage = baseDamage + (baseDamage * 1.0f);
                baseDamage += 15;
                break;     
        }
        return damage;
    }

    public void SetDamage()
    {
        totalDamage = CalculateDamage();
        textDamage.text = "Damage: " + totalDamage.ToString();
    }
}