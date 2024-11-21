using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationAsteroid : MonoBehaviour
{
    //Life of the asteroid
    public int life;
    //Comprobe if the asteroid is a child
    public bool isChild = false;
    //Comprobe if the asteroid is invencible
    public bool isInvencible = false;
    //Type of the asteroid
    public int typeOfAsteroid;
    //Type of the asteroid have in game
    public const int TYPEHUGE = 0;
    public const int TYPEBIG = 1;
    public const int TYPEMEDIUM = 2;
    //Velocity of the asteroid
    public const int VELOCITY = 1;
    //Movement of the asteroid
    public float movementX = 0;
    public float movementY = 0;
    //Create asteroid
    public CreateAsteroid[] createAsteroids = new CreateAsteroid[3];
    



}
