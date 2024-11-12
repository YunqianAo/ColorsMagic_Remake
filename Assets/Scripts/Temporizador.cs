using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Temporizador : MonoBehaviour
{
    public float timeleft = 15;
    public float remainingTime;
    bool timerIsRunning = true;
    public Text timeText;
    Damage damage;
    ColorGenerator colorGenerator;
    void Start()
    {
        resetTimer();
        colorGenerator = GameObject.FindObjectOfType<ColorGenerator>();
    }

    // Update is called once per frame
    void Update()
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
            colorGenerator.GenerateRandomRGBColor();
            resetTimer();
            timerIsRunning = true;
        }
        timeText.text = remainingTime.ToString();
    }

    void resetTimer()
    {
        remainingTime = timeleft;
    }
   
}
