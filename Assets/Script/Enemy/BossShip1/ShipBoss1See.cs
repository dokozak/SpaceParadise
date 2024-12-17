using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBoss1See : MonoBehaviour
{
    Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        //Get tranform for the player
        playerTransform = GameObject.FindGameObjectWithTag("PointBossShip1").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float anguloZ = angleZ(transform.position.x, transform.position.y, playerTransform.position.x, playerTransform.position.y);


        transform.rotation = Quaternion.Euler(0, 0, anguloZ+90+180);
    }



    public float angleZ(float x1, float y1, float x2, float y2)
    {

        float deltaX = x2 - x1;
        float deltaY = y2 - y1;


        float anguloEnGrados = Mathf.Atan2(deltaY, deltaX) * Mathf.Rad2Deg;

        return anguloEnGrados;
    }
}
