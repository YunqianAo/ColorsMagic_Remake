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

    private Damage damage;
    private ButtonManager butonmanager;
    private void Start()
    {
        remainingTime = timeleft;
        butonmanager = GameObject.FindObjectOfType<ButtonManager>();
        colorGenerator = GameObject.FindObjectOfType<ColorGenerator>();
    }

    private void Update()
    {
        if (butonmanager.atack || butonmanager.defense)
        {

            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
                remainingTime = Mathf.Max(remainingTime, 0);
            }
            else
            {
                if (timerIsRunning)
                {
                    timerIsRunning = false;
                }
            }


            if (!timerIsRunning)
            {
                foreach (Entity entity in entities)
                {
                    if (entity.isEnemy)
                        entity.GetDamage().SetDamage(true);
                    else
                        entity.GetDamage().SetDamage();

                    entity.Attack();
                }
                colorGenerator.GenerateRandomRGBColor();
                ResetTimer();
                timerIsRunning = true;

            }
            timeText.text = remainingTime.ToString("F2");

        }


    }
    public void ResetTimer()
    {

        remainingTime = timeleft;
        butonmanager.atack = false;
        butonmanager.defense = false;
    }
}

