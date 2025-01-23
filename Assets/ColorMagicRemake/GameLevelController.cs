using UnityEngine;

public class GameLevelController : MonoBehaviour
{
    // Define the total number of levels
    public int totalLevels = 4;

    // Define a method to check if a level is unlocked
    public bool IsLevelUnlocked(int levelIndex)
    {
        // You can replace this with your actual unlocking logic, e.g., PlayerPrefs or other storage
        return levelIndex <= unlockedLevels;
    }

    // Current unlocked levels
    public int unlockedLevels = 1;

    private const string ProgressKey = "UnlockedLevels";

    private void Awake()
    {
        LoadProgress();
    }

    private void SaveProgress()
    {
        PlayerPrefs.SetInt(ProgressKey, unlockedLevels);
        PlayerPrefs.Save();
    }

    private void LoadProgress()
    {
        if (PlayerPrefs.HasKey(ProgressKey))
        {
            unlockedLevels = PlayerPrefs.GetInt(ProgressKey);
        }
    }
}
