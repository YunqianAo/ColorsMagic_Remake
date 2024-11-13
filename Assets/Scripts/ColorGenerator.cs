using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorGenerator : MonoBehaviour
{
    [SerializeField] private Image randomcolorDisplay;
    [SerializeField] private Image enemycolorDisplay;
    public float red, green, blue;
    private Color color;
    private Color enemyColor;
    private EnemyTurn enemy;
    
    void Start()
    {
        enemy = GameObject.FindObjectOfType<EnemyTurn>();
        GenerateRandomRGBColor();
    }

    public void GenerateRandomRGBColor()
    {
        red = Random.Range(0f, 1f);
        green = Random.Range(0f, 1f);
        blue = Random.Range(0f, 1f);
        color = new Color(red, green, blue);

        if (randomcolorDisplay != null)
        {
            randomcolorDisplay.color = color;
        }
        GenerateEnemyRGBColor();
    }
  
   public Color GetColor() => color;

    public void GenerateEnemyRGBColor()
    {
        red = color.r * enemy.chance;
        green = color.g * enemy.chance;
        blue = color.b * enemy.chance;
        enemyColor = new Color(red, green, blue);
        //red += Random.Range(-Enemy.chance, Enemy.chance);
        //green += Random.Range(-Enemy.chance, Enemy.chance);
        //blue += Random.Range(-Enemy.chance, Enemy.chance);
        //color = new Color(red, green, blue);
        //if(red > 1.0f)
        //{
        //    red = 1.0f;
        //}
        //else if(red <0)
        //{
        //    red = 0;
        //}
        //if (green > 1.0f)
        //{
        //    green = 1.0f;
        //}
        //else if (green < 0)
        //{
        //    green = 0;
        //}
        //if (blue > 1.0f)
        //{
        //    blue = 1.0f;
        //}
        //else if (blue < 0)
        //{
        //    blue = 0;
        //}
        if (enemycolorDisplay != null)
        {
            enemycolorDisplay.color = enemyColor;
        }
    }
    public Color GetEnemyColor() => enemyColor;
}
