using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorGenerator : MonoBehaviour
{
    [SerializeField] private Image randomcolorDisplay;
    public float red, green, blue;
    private Color color;

    void Start()
    {
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
    }
}
