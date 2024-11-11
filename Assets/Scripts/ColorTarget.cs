using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTarget : MonoBehaviour
{
    private Color color = new Color(1, .3f, .5f);

    public Color GetColor() => color;
}