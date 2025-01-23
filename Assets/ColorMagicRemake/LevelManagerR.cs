using UnityEngine;

public class LevelManagerR : MonoBehaviour
{
    public int totalLevels = 4; // �ܹ��ؿ���

    private void Start()
    {
        // ��ʼ���������ݣ�ֻ�ڵ�һ��������Ϸʱִ�У�
        if (!PlayerPrefs.HasKey("LevelUnlocked"))
        {
            PlayerPrefs.SetInt("LevelUnlocked", 1); // Ĭ�Ͻ����� 1 ��
            PlayerPrefs.Save();
        }
    }

    // ���ؿ��Ƿ����
    public bool IsLevelUnlocked(int level)
    {
        int unlockedLevel = PlayerPrefs.GetInt("LevelUnlocked", 1);
        return level <= unlockedLevel;
    }

    // ������һ��
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
