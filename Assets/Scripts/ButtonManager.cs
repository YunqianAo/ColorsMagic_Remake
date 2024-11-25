using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public bool attack = false;
    public bool defense = false;

    public void atackButton()
    {
        if (!defense)
            attack = true;
    }

    public void defenseButton()
    {
        if (!attack)
            defense = true;
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Lobby");
    }
}