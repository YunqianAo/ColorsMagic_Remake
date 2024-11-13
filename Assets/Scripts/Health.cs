using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float initialHealth = 300;
    private float currentHealth;

    private HealthBar healthBar;

    private void Awake()
    {
        ResetHealth();
    }

    private void Start()
    {
        healthBar = GameObject.FindObjectOfType<HealthBar>();
    }

    public void ApplyDamage(float damage)
    {
        currentHealth -= damage;
        float percentage = (currentHealth / initialHealth);
        Debug.Log(percentage);
        healthBar.UpdateBar(percentage);
    }

    private void ResetHealth()
    {
        currentHealth = initialHealth;
    }
}
