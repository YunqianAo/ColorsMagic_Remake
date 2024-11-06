using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;


public class Puntuacion : MonoBehaviour
{
    public TextMeshProUGUI textPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        textPuntuacion.text =  ScoreManager.instance.score.ToString("0000");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
