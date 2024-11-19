using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image barImage;

    public void UpdateBar(float percentage)
    {
        barImage.fillAmount = percentage;
        Debug.Log(barImage.fillAmount);
    }
}