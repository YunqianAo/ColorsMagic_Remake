using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] levelButtons;
    
    void Start()
    {
        int levelsUnlocked = PlayerPrefs.GetInt("LevelsUnlocked", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelsUnlocked)
            {
                levelButtons[i].interactable = true;
            }
            else
            {
                levelButtons[i].interactable = false;
            }
        }
    }

    public void CompleteLevel(int level)
    {
        
        int levelsUnlocked = PlayerPrefs.GetInt("LevelsUnlocked", 1);
        if (level >= levelsUnlocked)
        {
            PlayerPrefs.SetInt("LevelsUnlocked", level + 1);
            PlayerPrefs.Save();
        }
    }
}