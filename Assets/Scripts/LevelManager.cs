using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button[] levelButtons;
    [SerializeField] private TMPro.TextMeshProUGUI levelText;
    
    void Start()
    {
        int levelsUnlocked = PlayerPrefs.GetInt("LevelsUnlocked", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelsUnlocked)
            {
                levelButtons[i].interactable = false;
            }
            else
            {
                levelButtons[i].interactable = true;
            }
        }

        levelText.text = "Current Level " + PlayerPrefs.GetInt("LevelsUnlocked", 1);
    }

    public void StartLevel(int level)
    {
        PlayerPrefs.SetInt("CurrentLevel", level);
        PlayerPrefs.Save();
        SceneManager.LoadScene("GameP");
    }
}