using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerL1 : MonoBehaviour
{
    [Header("Level Settings")]
    public int totalRounds = 5; // ��ǰ�ؿ���Ҫ��ɵĻغ���
    private int currentRound = 0; // ��ǰ�غϼ���

    [Header("UI Settings")]
    public GameObject victoryPanel; // ͨ�ؽ���
    public GameObject colorBlockSpawner; // ɫ��������������һ��ר������ɫ��Ľű������

    private void Start()
    {
        // ��ʼ���غϼ����ͽ���
        currentRound = 0;
        if (victoryPanel != null)
            victoryPanel.SetActive(false);

        StartNewRound();
    }

    // ��ʼ�µĻغ�
    private void StartNewRound()
    {
        if (colorBlockSpawner != null)
        {
            // ����ɫ�������߼�������ʵ�ּ��·�ʾ����
            colorBlockSpawner.GetComponent<ColorBlockSpawner>().GenerateBlocks();
        }
    }

    // ��������һ���غ�ʱ����
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

    // ͨ�ص�ǰ�ؿ�
    private void CompleteLevel()
    {
        Debug.Log("Level Complete!");

        // ��ʾͨ�ؽ���
        if (victoryPanel != null)
            victoryPanel.SetActive(true);

        // ������һ���ؿ�
        UnlockNextLevel();

        // ���� Lobby �����������ӳٵ��ã�
        Invoke(nameof(GoToLobby), 2f);
    }

    // ������һ���ؿ�
    private void UnlockNextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("Level_" + (currentLevel + 1), 1); // �������״̬
    }

    // ���� Lobby ����
    private void GoToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
