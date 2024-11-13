using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurn : MonoBehaviour
{
    bool enemyTurn = false;
    public float chance = 0.4f;
    private ColorGenerator colorGenerator;
    void Start()
    {
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
