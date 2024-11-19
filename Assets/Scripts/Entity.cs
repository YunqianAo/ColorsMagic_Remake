using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] Health health;
    [SerializeField] Damage damage;
    [SerializeField] public bool isEnemy = false;

    private ButtonManager buttonManager;

    private void Start()
    {
        buttonManager = GameObject.FindObjectOfType<ButtonManager>();
    }

    public void Attack()
    {
        if (buttonManager.attack) 
        health.ApplyDamage(damage.GetTotalDamage());
    }

    public Damage GetDamage() => damage;
}