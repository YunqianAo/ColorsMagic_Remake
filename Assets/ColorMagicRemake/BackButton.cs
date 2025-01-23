using UnityEngine.SceneManagement;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // 返回主菜单场景
    }
}
