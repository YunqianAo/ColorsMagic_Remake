using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager
{
    public static ScoreManager instance = new ScoreManager();

    private int score = 0;

    public int GetScore() => score;
    public int SetScore(int newScore) => score += newScore;
}