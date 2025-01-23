using UnityEngine;

public class ColorBlock : MonoBehaviour
{
    public bool isCorrectBlock = false; // 是否为正确的色块

    private void OnMouseDown()
    {
        if (isCorrectBlock)
        {
            Debug.Log("Correct Block!");
            FindObjectOfType<LevelManagerL1>().OnRoundCompleted();
        }
        else
        {
            Debug.Log("Wrong Block! Try Again.");
        }
    }
}

