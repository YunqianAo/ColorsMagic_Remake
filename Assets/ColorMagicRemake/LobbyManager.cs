using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    public GameObject levelButtonPrefab; // 关卡按钮预制体
    public Transform levelGrid;         // 按钮网格布局容器
    public Sprite unlockedSprite;       // 解锁关卡按钮图标
    public Sprite lockedSprite;         // 未解锁关卡按钮图标
    private LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        GenerateLevelButtons();
    }

    private void GenerateLevelButtons()
    {
        int totalLevels = levelManager.totalLevels;

        for (int i = 1; i <= totalLevels; i++)
        {
            GameObject buttonObj = Instantiate(levelButtonPrefab, levelGrid);
            Button button = buttonObj.GetComponent<Button>();
            Text buttonText = buttonObj.GetComponentInChildren<Text>();

            // 更新按钮文字
            buttonText.text = $"Level {i}";

            // 检查解锁状态
            if (levelManager.IsLevelUnlocked(i))
            {
                button.image.sprite = unlockedSprite;
                int levelIndex = i; // 捕获当前关卡索引
                button.onClick.AddListener(() => LoadLevel(levelIndex));
            }
            else
            {
                button.image.sprite = lockedSprite;
                button.interactable = false; // 禁用按钮
            }
        }
    }

    private void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene($"Level{levelIndex}"); // 加载对应关卡场景
    }
}
