using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerL1 : MonoBehaviour
{
    [Header("Level Settings")]
    public int totalRounds = 5; // 当前关卡需要完成的回合数
    private int currentRound = 0; // 当前回合计数

    [Header("UI Settings")]
    public GameObject victoryPanel; // 通关界面
    public GameObject colorBlockSpawner; // 色块生成器（引用一个专门生成色块的脚本或对象）

    private void Start()
    {
        // 初始化回合计数和界面
        currentRound = 0;
        if (victoryPanel != null)
            victoryPanel.SetActive(false);

        StartNewRound();
    }

    // 开始新的回合
    private void StartNewRound()
    {
        if (colorBlockSpawner != null)
        {
            // 调用色块生成逻辑（具体实现见下方示例）
            colorBlockSpawner.GetComponent<ColorBlockSpawner>().GenerateBlocks();
        }
    }

    // 当玩家完成一个回合时调用
    public void OnRoundCompleted()
    {
        currentRound++;

        if (currentRound >= totalRounds)
        {
            CompleteLevel();
        }
        else
        {
            StartNewRound();
        }
    }

    // 通关当前关卡
    private void CompleteLevel()
    {
        Debug.Log("Level Complete!");

        // 显示通关界面
        if (victoryPanel != null)
            victoryPanel.SetActive(true);

        // 解锁下一个关卡
        UnlockNextLevel();

        // 返回 Lobby 场景（可以延迟调用）
        Invoke(nameof(GoToLobby), 2f);
    }

    // 解锁下一个关卡
    private void UnlockNextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Level_" + (currentLevel + 1), 1); // 保存解锁状态
    }

    // 返回 Lobby 场景
    private void GoToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
