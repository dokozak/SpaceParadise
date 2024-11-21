using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRedShip : MonoBehaviour
{
    //information of enemy
    InformationEnemy information;
    //The rotatio of the ship
    private int rotation = 50;
    //Comprobe the direction
    private bool isRight = true;
    //Angle the ship
    private float angle;
    //Movement of the ship
    int movement;
    // Start is called before the first frame update
    void Start()
    {
       //Get the information enemy
       information = GetComponent<InformationEnemy>();
       information.movementX = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        if(isRight)
        {
            //The next rotation
            if(angle > 30) 
            {
            rotation = -50;
            isRight = false;
            }
            

        }
        else
        {
            //The next rotation
            if (angle < -30)
            {
                rotation = 50;
                isRight = true;
            }
        }
        //Angle of the ship
        angle += rotation * Time.deltaTime;
        //Rotate the ship and move this
        transform.Rotate(0,  0, rotation * Time.deltaTime);
        transform.position = new Vector3(transform.position.x + (information.movementX * Time.deltaTime), transform.position.y + (information.movementY * Time.deltaTime), transform.position.z);
    }

    //Movement of the red ship
    private void ShipMovement()
    {
        
    }
}
