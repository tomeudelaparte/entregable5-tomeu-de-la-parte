using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Almacena el prefab del obst�culo
    public GameObject obstaclePrefab;

    // Posici�n principal del obst�culo
    private Vector3 spawnPos = new Vector3(0, 0, 30);

    // Almacena un valor aleatorio en referencia a Y
    private float randomY;

    // Almacena el tiempo que tarda en iniciarse la funci�n Invoke
    private float invokeTime = 0.5f;

    // Almacena el ratio entre cada repetici�n del Invoke
    private float invokeRate = 5f;

    // Almacena el rango para el valor aleatorio
    private float rangeNumber = 10f;

    // Se ejecuta una vez al iniciar el juego
    void Start()
    {
        // Repite la funci�n de spawn cada cierto tiempo
        InvokeRepeating("SpawnObstacle", invokeTime, invokeRate);
    }

    // Funci�n que spawnea, uno detr�s de otro, un obst�culo en una altura aleatoria
    public void SpawnObstacle()
    {
        // Obtiene un valor aleatorio entre el rango obtenido
        randomY = Random.Range(-rangeNumber, rangeNumber);

        // Obtiene la posici�n para el obst�culo
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);

        // Instancia un gameObject a partir del prefab del obst�culo con una posici�n y rotaci�n
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
