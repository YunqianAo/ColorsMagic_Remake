using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColorsMagic : MonoBehaviour
{
    public static ColorsMagic Instance { get; private set; }
    public Image fadeImage; // Imagen usada para el efecto de fade (debe cubrir toda la pantalla).
    public float fadeDuration = 1f; // Duración del fade.


    private void Awake()
    {
        // Configura el Singleton.
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Hace que el objeto persista entre escenas.
        }
        else
        {
            Destroy(gameObject); // Elimina instancias duplicadas.
        }
    }
    public void ChangeToScene(string sceneName)
    {
        // Llama a la corutina para hacer un Fade Out y cambiar de escena.
        if (fadeImage != null)
        {
            StartCoroutine(FadeIn());
            StartCoroutine(FadeOut(sceneName));
        }
        else
        {
            // Si no hay imagen de fade, cambia directamente.
            SceneManager.LoadScene(sceneName);
        }
    }

    private IEnumerator FadeIn()
    {
        fadeImage.gameObject.SetActive(true);
        // Comienza totalmente opaco.
        float alpha = 1f;

        while (alpha > 0f)
        {
            alpha -= Time.deltaTime / fadeDuration;
            SetFadeAlpha(alpha);
            yield return null;
        }

        // Asegúrate de que quede completamente transparente.
        SetFadeAlpha(0f);
    }

    private IEnumerator FadeOut(string sceneName)
    {
        // Comienza totalmente transparente.
        float alpha = 0f;

        while (alpha < 1f)
        {
            alpha += Time.deltaTime / fadeDuration;
            SetFadeAlpha(alpha);
            yield return null;
        }

        // Asegúrate de que quede completamente opaco.
        SetFadeAlpha(1f);
        fadeImage.gameObject.SetActive(false);

        // Cambia a la nueva escena.
        SceneManager.LoadScene(sceneName);
    }

    private void SetFadeAlpha(float alpha)
    {
        // Ajusta la opacidad de la imagen.
        Color color = fadeImage.color;
        color.a = Mathf.Clamp01(alpha); // Asegura que el valor esté entre 0 y 1.
        fadeImage.color = color;
    }
}
