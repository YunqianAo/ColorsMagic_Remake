using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurn : MonoBehaviour
{
    bool enemyTurn = false;
    public float minChance= 0.4f;
    public float maxChance = 0.6f;
    public float chance;
    private ColorGenerator colorGenerator;
    void Start()
    {
        chance = Random.Range(minChance, maxChance);
        colorGenerator = GameObject.FindObjectOfType<ColorGenerator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(enemyTurn)
        {

        }
    }
}
