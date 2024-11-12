using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Temporizador : MonoBehaviour
{
    public float timeleft = 30;
    public Text timeText;
    public Damage damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeleft > 0)
        {
            timeleft -= Time.deltaTime;
        }
        else
        {
            gameOver();
        }
        timeText.text = timeleft.ToString();
    }
    void gameOver()
    {
        SceneManager.LoadScene("lobby");
        
    }
}
