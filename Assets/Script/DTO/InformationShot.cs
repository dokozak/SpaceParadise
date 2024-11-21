using UnityEngine;

public class InformationShot : MonoBehaviour
{
    //Damage who have the shot
    public int damage = 0;
    //If is lucky the damage shot does quintuple damage
    public bool isLucky = false;
    //Get the time of the shot is shooted
    public float timeLife = 0;
    //Type of the shot
    public int type = 0;
    //Speed
    public const float speed = 10;
    public float velocity = 0.2f;
    //Movement speed
    public int movement = 10;
    //Movement of the shot
    public float movementX = 0;
    public float movementY = 0;
    //Angle to the ship
    public float angleZ = 0;

}
