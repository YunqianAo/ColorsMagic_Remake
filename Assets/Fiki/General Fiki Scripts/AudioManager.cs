using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance; // Singleton para acceder globalmente

    [Header("Audio Sources")]
    public AudioSource musicSource; // Fuente para la m�sica de fondo
    public AudioSource sfxSource;   // Fuente para efectos de sonido

    [Header("Music Clips")]
    public AudioClip backgroundMusic; // Clip de m�sica de fondo (opcional)

    private void Awake()
    {
        // Configura el Singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // No destruye este objeto al cambiar de escena
        }
        else
        {
            Destroy(gameObject); // Evita duplicados
        }
    }

    private void Start()
    {
        // Reproduce m�sica de fondo si est� configurada
        if (backgroundMusic != null)
        {
            PlayMusic(backgroundMusic);
        }
    }

    /// <summary>
    /// Reproduce m�sica de fondo
    /// </summary>
    /// <param name="clip">Clip de audio a reproducir</param>
    public void PlayMusic(AudioClip clip)
    {
        if (musicSource != null)
        {
            musicSource.clip = clip;
            musicSource.loop = true; // Asegura que la m�sica se repita
            musicSource.Play();
        }
        else
        {
            Debug.LogWarning("No se ha asignado una fuente de m�sica.");
        }
    }

    /// <summary>
    /// Detiene la m�sica actual
    /// </summary>
    public void StopMusic()
    {
        if (musicSource != null)
        {
            musicSource.Stop();
        }
    }

    /// <summary>
    /// Reproduce un efecto de sonido
    /// </summary>
    /// <param name="clip">Clip de sonido a reproducir</param>
    public void PlaySFX(AudioClip clip)
    {
        if (sfxSource != null)
        {
            sfxSource.PlayOneShot(clip); // Reproduce sin interrumpir otros sonidos
        }
        else
        {
            Debug.LogWarning("No se ha asignado una fuente de efectos de sonido.");
        }
    }
}
