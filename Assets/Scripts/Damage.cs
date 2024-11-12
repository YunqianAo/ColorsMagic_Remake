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

    private void Update()
    {
        totalDamage = CalculateDamage();//esto no va aqui pero no sé donde
        textDamage.text = "Damage: " + totalDamage.ToString();
    }
    private float CalculateDamage() 
    {
        float precision = colorPrecision.GetPrecision();
        switch (precision) 
        {
            case < 50:
                totalDamage = 0;
                break;
            case < 60:
                totalDamage = baseDamage - (baseDamage * 0.1f);
                break;
            case < 80:
                totalDamage = baseDamage + (baseDamage * 0.15f);
                baseDamage += 5;
                break;
            case < 98:
                totalDamage = baseDamage + (baseDamage * 0.35f);
                baseDamage += 10;
                break;    
            case <= 100:
                totalDamage = baseDamage + (baseDamage * 1.0f);
                baseDamage += 15;
                break;     
        }
        return totalDamage;
    }
}
