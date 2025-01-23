using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player; // El objeto del personaje a seguir
    public float minX; // L�mite izquierdo
    public float maxX; // L�mite derecho
    public float minY; // L�mite inferior
    public float maxY; // L�mite superior

    private float cameraHalfWidth;
    private float cameraHalfHeight;

    private void Update()
    {

        // Calcula la mitad del tama�o de la c�mara en X e Y
        cameraHalfHeight = Camera.main.orthographicSize;
        cameraHalfWidth = cameraHalfHeight * Camera.main.aspect;

        // Calcula la posici�n deseada de la c�mara en base a la posici�n del jugador
        float targetX = Mathf.Clamp(player.position.x, minX + cameraHalfWidth, maxX - cameraHalfWidth);
        float targetY = Mathf.Clamp(player.position.y, minY + cameraHalfHeight, maxY - cameraHalfHeight);

        // Aplica la nueva posici�n de la c�mara
        transform.position = new Vector3(targetX, targetY, transform.position.z);
    }
}
