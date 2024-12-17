using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationEnemyShot : MonoBehaviour
{
    //Damage who have the shot
    public int damage = 0;
    //Type of the shot
    public int type = 0;
    //Speed
    public float speed = 1;
    public float velocity = 0.2f;
    //Movement speed
    public int movement = 10;
    //Movement of the shot
    public float movementX = 0;
    public float movementY = 0;
    //Angle to the ship
    public float angleZ = 0;
}
