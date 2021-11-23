using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Posición predeterminada
    private Vector3 defaultPosition = Vector3.zero;

    // Velocidad de movimiento
    public float speed = 10f;

    // Velocidad de rotación
    public float turnSpeed = 20f;

    // Almacena el axis vertical
    private float verticalInput;

    // Distancia límite para terminar el juego
    private int zMax = 450;

    // Se ejecuta una vez al iniciar el juego
    void Start()
    {
        // Posiciona el player en la posición predeterminada
        transform.position = defaultPosition;
    }

    // Se ejecuta a cada frame
    void Update()
    {
        // Obtiene el axis vertical en negativo
        verticalInput = -Input.GetAxis("Vertical");

        // Desplaza constantemente el avión hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Rotará el avión en función del axis
        transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime * verticalInput);

        // Si la posición del avión es mayor o igual a zMax
        if (transform.position.z >= zMax)
        {
            // Imprime por consola el mensaje y pausa toda la escena
            Debug.Log("THE END");
            Time.timeScale = 0f;
        }
    }
}
