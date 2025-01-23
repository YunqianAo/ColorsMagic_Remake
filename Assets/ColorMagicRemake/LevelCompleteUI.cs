using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCompleteUI : MonoBehaviour
{
    public Button nextLevelButton;  // 下一关按钮

    void Start()
    {
        nextLevelButton.onClick.AddListener(OnNextLevelButtonClicked);
    }

    // 点击按钮时，加载下一个关卡
    void OnNextLevelButtonClicked()
    {
        LevelManagerL1 levelManager = FindObjectOfType<LevelManagerL1>();
        levelManager.CompleteLevel();  // 完成当前关卡
        gameObject.SetActive(false);  // 隐藏胜利面板
    }
}
