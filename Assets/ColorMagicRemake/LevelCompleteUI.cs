using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCompleteUI : MonoBehaviour
{
    public Button nextLevelButton;  // ��һ�ذ�ť

    void Start()
    {
        nextLevelButton.onClick.AddListener(OnNextLevelButtonClicked);
    }

    // �����ťʱ��������һ���ؿ�
    void OnNextLevelButtonClicked()
    {
        LevelManagerL1 levelManager = FindObjectOfType<LevelManagerL1>();
        levelManager.CompleteLevel();  // ��ɵ�ǰ�ؿ�
        gameObject.SetActive(false);  // ����ʤ�����
    }
}
