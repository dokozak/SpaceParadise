using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLooking : MonoBehaviour
{
    //information of enemy
    InformationEnemy information;
    //The rotatio of the ship
    private int rotation = 180;
    //Comprobe the direction
    private bool isRight = true;
    //Angle the ship
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        //Get the information enemy
        information = GetComponent<InformationEnemy>();

    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the ship and move this
        transform.Rotate(0, 0, rotation * Time.deltaTime);
    }
}