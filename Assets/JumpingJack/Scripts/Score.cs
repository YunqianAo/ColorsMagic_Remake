using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private string scoreTextObjectName = "Score"; // Nombre del objeto de texto del marcador
    private TextMeshProUGUI scoreText; // Referencia al marcador
    private Timer timer; // Referencia al temporizador
    private int levelScore; // Puntuaci�n del nivel actual
    private int lastDisplayedScore = -1; // Para evitar actualizaciones innecesarias

    void Start()
    {
        timer = FindObjectOfType<Timer>(); // Encuentra el temporizador
        InitializeScoreText(); // Inicializa el marcador
        ResetScore(); // Reinicia el marcador al empezar
    }

    void Update()
    {
        if (timer != null)
        {
            UpdateLevelScore(); // Actualiza la puntuaci�n seg�n el tiempo transcurrido
        }
    }

    private void UpdateLevelScore()
    {
        levelScore = (int)timer.totalTime;

        if (levelScore != lastDisplayedScore)
        {
            UpdateScoreDisplay();
            lastDisplayedScore = levelScore;
        }
    }

    private void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {levelScore}";
        }
    }

    public void ResetScore()
    {
        levelScore = 0;
        lastDisplayedScore = -1;
        UpdateScoreDisplay();
    }

    /// <summary>
    /// Llama a este m�todo al completar el nivel para a�adir los puntos al total acumulado.
    /// </summary>
    public void AddScoreToTotal()
    {
        // Obtiene la puntuaci�n total acumulada
        int totalScore = PlayerPrefs.GetInt("totalScore", 0);

        // A�ade la puntuaci�n del nivel actual
        totalScore += levelScore;

        // Guarda la puntuaci�n total actualizada
        PlayerPrefs.SetInt("totalScore", totalScore);
        PlayerPrefs.Save(); // Asegura que los datos se escriban en disco
    }

    private void InitializeScoreText()
    {
        GameObject textObject = GameObject.Find(scoreTextObjectName);

        if (textObject != null)
        {
            scoreText = textObject.GetComponent<TextMeshProUGUI>();
        }
        else
        {
            Debug.LogWarning($"No se encontr� el objeto TextMeshProUGUI con el nombre '{scoreTextObjectName}'.");
        }
    }
}
