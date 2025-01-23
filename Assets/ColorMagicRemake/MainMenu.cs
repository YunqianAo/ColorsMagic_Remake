using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Lobby"); 
    }
    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings"); 
    }
    public void QuitGame()
    {
        Application.Quit(); 
        Debug.Log("Game Quit!"); 
    }

}
