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
        ScoreManager.instance.OnScoreChanged.AddListener(UpdateScoreText);
    }

    private void UpdateScoreText(int newScore)
    {
        scoreText.text = newScore.ToString();
    }

    private void OnDestroy()
    {
        ScoreManager.instance.OnScoreChanged.RemoveListener(UpdateScoreText);
    }
}
