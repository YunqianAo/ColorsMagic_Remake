using UnityEngine;
using UnityEngine.SceneManagement;  // ���ڼ��س���

public class LevelManagerL1 : MonoBehaviour
{
    public int currentLevel = 1; // ��ǰ�ؿ�
    public int totalLevels = 4;  // �ܹؿ���
    public GameObject levelCompletePanel; // �ؿ����ʱ��UI���

    // ����ָ���ؿ�
    public void LoadLevel(int levelIndex)
    {
        if (levelIndex <= totalLevels)
        {
            SceneManager.LoadScene("Level" + levelIndex);  // ͨ���������Ƽ���
        }
    }

    // ��ɹؿ���������һ���ؿ�
    public void CompleteLevel()
    {
        if (currentLevel < totalLevels)
        {
            currentLevel++;
            levelCompletePanel.SetActive(true);  // ��ʾ�ؿ����UI
        }
        else
        {
            // ������йؿ���ɣ���ʾ��Ϸ��������
            Debug.Log("All Levels Completed!");
        }
    }
}
