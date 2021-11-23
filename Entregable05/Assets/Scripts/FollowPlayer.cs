using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Almacena el player
    public GameObject player;

    // Offset de la c�mara
    private Vector3 offset = new Vector3(40, 0, 0);

    // Se ejecuta despu�s de cada update de cada frame
    void LateUpdate()
    {
        // Posiciona la c�mara en la posici�n del player respecto al offset
        transform.position = player.transform.position + offset;
    }
}
