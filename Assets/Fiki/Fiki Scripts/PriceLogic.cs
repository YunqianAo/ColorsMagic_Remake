using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceLogic : MonoBehaviour
{
    public AudioClip itemCollected; // Arrastra tu clip de audio aqu� en el Inspector
    public GameObject collectParticlesPrefab; // Prefab de part�culas para la recogida

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Manager.instance.hasPrice = true;
            Debug.Log("Price has been taken!");

            AudioManager.instance.PlaySFX(itemCollected);

            // Reproducir part�culas de recolecci�n
            if (collectParticlesPrefab != null)
            {
                GameObject particles = Instantiate(collectParticlesPrefab, transform.position, Quaternion.identity);

                // Obtener el sistema de part�culas y destruirlo despu�s de su duraci�n
                ParticleSystem particleSystem = particles.GetComponent<ParticleSystem>();
                if (particleSystem != null)
                {
                    Destroy(particles, particleSystem.main.duration + particleSystem.main.startLifetime.constant);
                }
                else
                {
                    Debug.LogWarning("El prefab de part�culas no tiene un sistema de part�culas.");
                }
            }
            else
            {
                Debug.LogWarning("Prefab de part�culas no asignado en el inspector.");
            }

            // Desactiva la manzana
            gameObject.SetActive(false);
        }
    }
}

