using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text =  ScoreManager.instance.GetScore().ToString();
    }

    private void Update()
    {
        scoreText.text = ScoreManager.instance.GetScore().ToString();
    }
}
