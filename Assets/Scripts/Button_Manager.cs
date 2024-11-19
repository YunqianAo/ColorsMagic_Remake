using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    public bool atack = false;
    public bool defense = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void atackButton()
    {
        atack = true;
    }
    public void defenseButton()
    {
        defense = true;
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Lobby");
    }
}
