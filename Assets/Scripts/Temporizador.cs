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
    [SerializeField] private List<Entity> entities = new List<Entity>(2);

    private void Start()
    {
        remainingTime = timeleft;
        colorGenerator = GameObject.FindObjectOfType<ColorGenerator>();
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
            foreach (Entity entity in entities)
            {
                entity.GetDamage().SetDamage();
                entity.Attack();
            }
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