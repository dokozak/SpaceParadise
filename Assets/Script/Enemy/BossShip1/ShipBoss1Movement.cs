using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBoss1Movement : MonoBehaviour
{
    private GameObject newgameObject = null;
    private float time = 0;
    private GameObject[] movementPoint;
    private Vector3 thisPosition;
    private int value;
    private void Start()
    {
        movementPoint = GameObject.FindGameObjectsWithTag("MovementBossShip1");
        newgameObject = GameObject.FindGameObjectWithTag("PointBossShip1");
        thisPosition = gameObject.transform.position;
        value = -1;
    }
    // Update is called once per frame
    void Update()
    {
        
        if(time> 4)
        {
            int nextMovement = value;
            while (nextMovement == value)
            {
                nextMovement = UnityEngine.Random.Range(0, movementPoint.Length);
                
            }
            value = nextMovement;
            newgameObject = movementPoint[value];
            thisPosition = gameObject.transform.position;
            time = 0;
        }

       transform.position = Vector3.Lerp(transform.position, newgameObject.transform.position, time/4 * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
       time += Time.deltaTime;
    }
}
