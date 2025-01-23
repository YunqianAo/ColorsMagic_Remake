using UnityEngine;
using UnityEngine.SceneManagement;  // 用于加载场景

public class LevelManagerL1 : MonoBehaviour
{
    public int currentLevel = 1; // 当前关卡
    public int totalLevels = 4;  // 总关卡数
    public GameObject levelCompletePanel; // 关卡完成时的UI面板

    // 加载指定关卡
    public void LoadLevel(int levelIndex)
    {
        if (levelIndex <= totalLevels)
        {
            SceneManager.LoadScene("Level" + levelIndex);  // 通过场景名称加载
        }
    }

    // 完成关卡，解锁下一个关卡
    public void CompleteLevel()
    {
        if (currentLevel < totalLevels)
        {
            currentLevel++;
            levelCompletePanel.SetActive(true);  // 显示关卡完成UI
        }
        else
        {
            // 如果所有关卡完成，显示游戏结束界面
            Debug.Log("All Levels Completed!");
        }
    }
}
