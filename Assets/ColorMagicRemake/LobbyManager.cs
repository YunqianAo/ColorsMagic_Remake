using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    public GameObject levelButtonPrefab; // �ؿ���ťԤ����
    public Transform levelGrid;         // ��ť���񲼾�����
    public Sprite unlockedSprite;       // �����ؿ���ťͼ��
    public Sprite lockedSprite;         // δ�����ؿ���ťͼ��
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

            // ���°�ť����
            buttonText.text = $"Level {i}";

            // ������״̬
            if (levelManager.IsLevelUnlocked(i))
            {
                button.image.sprite = unlockedSprite;
                int levelIndex = i; // ����ǰ�ؿ�����
                button.onClick.AddListener(() => LoadLevel(levelIndex));
            }
            else
            {
                button.image.sprite = lockedSprite;
                button.interactable = false; // ���ð�ť
            }
        }
    }

    private void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene($"Level{levelIndex}"); // ���ض�Ӧ�ؿ�����
    }
}
