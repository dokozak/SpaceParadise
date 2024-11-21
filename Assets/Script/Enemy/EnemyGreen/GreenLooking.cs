using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLooking : MonoBehaviour
{
    Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
      //Get tranform for the player
      playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float anguloZ = CalcularAnguloZ(transform.position.x, transform.position.y, playerTransform.position.x, playerTransform.position.y);

        // Establece la rotación en Z directamente, sin acumularla
        transform.rotation = Quaternion.Euler(0, 0, anguloZ + 90);
    }


    // Método que retorna el ángulo en Z necesario para que (x1, y1) mire hacia (x2, y2)
    public float CalcularAnguloZ(float x1, float y1, float x2, float y2)
    {
        // Calculamos la diferencia entre los puntos
        float deltaX = x2 - x1;
        float deltaY = y2 - y1;

        // Calculamos el ángulo en radianes usando Atan2 y luego lo convertimos a grados
        float anguloEnGrados = Mathf.Atan2(deltaY, deltaX) * Mathf.Rad2Deg;

        return anguloEnGrados;
    }
}
