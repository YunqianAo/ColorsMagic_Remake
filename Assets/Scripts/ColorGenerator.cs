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
        enemy.CalculateChance();
        red = color.r * enemy.GetChance();
        green = color.g * enemy.GetChance();
        blue = color.b * enemy.GetChance();
        enemyColor = new Color(red, green, blue);
        if (enemycolorDisplay != null)
        {
            enemycolorDisplay.color = enemyColor;
        }
    }
    public Color GetEnemyColor() => enemyColor;
}
