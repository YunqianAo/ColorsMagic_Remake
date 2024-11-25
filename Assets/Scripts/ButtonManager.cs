using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public bool attack = false;
    public bool defense = false;

    ColorsMagic ColorsMagic;
    private void Awake()
    {
        ColorsMagic = FindAnyObjectByType<ColorsMagic>();
    }

    public void atackButton()
    {
        attack = true;
        defense = false;
    }

    public void defenseButton()
    {
        defense = true;
        attack = false;
    }

    public void mainMenu()
    {
        ColorsMagic.ChangeToScene("Lobby");
    }
}