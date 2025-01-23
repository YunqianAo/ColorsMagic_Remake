using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Vacaciones : MonoBehaviour
{
    #region Singleton
    private static GameManager_Vacaciones _instance;
    public static GameManager_Vacaciones Instance => _instance;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }

    #endregion
}
