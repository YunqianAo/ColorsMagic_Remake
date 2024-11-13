using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Temporizador : MonoBehaviour
{
    [SerializeField] private float timeleft = 10;    
    [SerializeField] private Text timeText;
    private float remainingTime;
    private bool timerIsRunning = true;
    private ColorGenerator colorGenerator;
    private Damage damage;

    private void Start()
    {
        ResetTimer();
        colorGenerator = GameObject.FindObjectOfType<ColorGenerator>();
        damage = GameObject.FindObjectOfType<Damage>();
    }

    private void Update()
    {
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            remainingTime = Mathf.Max(remainingTime, 0);
        }
        else
        {
            if(timerIsRunning)
            {
                timerIsRunning = false;
            }
        }

        if(!timerIsRunning)
        {
            damage.SetDamage();
            colorGenerator.GenerateRandomRGBColor();
            ResetTimer();
            timerIsRunning = true;
        }
        timeText.text = remainingTime.ToString("F2");
    }

    private void ResetTimer()
    {
        remainingTime = timeleft;
    }
}