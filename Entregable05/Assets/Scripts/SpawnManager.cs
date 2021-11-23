using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Almacena el prefab del obstáculo
    public GameObject obstaclePrefab;

    // Posición principal del obstáculo
    private Vector3 spawnPos = new Vector3(0, 0, 30);

    // Almacena un valor aleatorio en referencia a Y
    private float randomY;

    // Almacena el tiempo que tarda en iniciarse la función Invoke
    private float invokeTime = 0.5f;

    // Almacena el ratio entre cada repetición del Invoke
    private float invokeRate = 5f;

    // Almacena el rango para el valor aleatorio
    private float rangeNumber = 10f;

    // Se ejecuta una vez al iniciar el juego
    void Start()
    {
        // Repite la función de spawn cada cierto tiempo
        InvokeRepeating("SpawnObstacle", invokeTime, invokeRate);
    }

    // Función que spawnea, uno detrás de otro, un obstáculo en una altura aleatoria
    public void SpawnObstacle()
    {
        // Obtiene un valor aleatorio entre el rango obtenido
        randomY = Random.Range(-rangeNumber, rangeNumber);

        // Obtiene la posición para el obstáculo
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);

        // Instancia un gameObject a partir del prefab del obstáculo con una posición y rotación
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
