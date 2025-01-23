using UnityEngine;

public class LevelManagerR : MonoBehaviour
{
    public int totalLevels = 4; // 总共关卡数

    private void Start()
    {
        // 初始化解锁数据（只在第一次运行游戏时执行）
        if (!PlayerPrefs.HasKey("LevelUnlocked"))
        {
            PlayerPrefs.SetInt("LevelUnlocked", 1); // 默认解锁第 1 关
            PlayerPrefs.Save();
        }
    }

    // 检查关卡是否解锁
    public bool IsLevelUnlocked(int level)
    {
        int unlockedLevel = PlayerPrefs.GetInt("LevelUnlocked", 1);
        return level <= unlockedLevel;
    }

    // 解锁下一关
    public void UnlockNextLevel(int currentLevel)
    {
        int unlockedLevel = PlayerPrefs.GetInt("LevelUnlocked", 1);
        if (currentLevel >= unlockedLevel && currentLevel < totalLevels)
        {
            PlayerPrefs.SetInt("LevelUnlocked", currentLevel + 1);
            PlayerPrefs.Save();
        }
    }
}
