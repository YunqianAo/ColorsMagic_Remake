using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] Health health;
    [SerializeField] Damage damage;
    [SerializeField] public bool isEnemy = false;

    public void Attack()
    {
        health.ApplyDamage(damage.GetTotalDamage());
    }

    public Damage GetDamage() => damage;
}