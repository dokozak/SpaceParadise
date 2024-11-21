using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //Information of player
    InformationPlayer information;

    private void Start()
    {
        //Information player
        information = GetComponent<InformationPlayer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Asteroid"))
        {
            Debug.Log("The nave is collision");
        }
        if (collision.collider.CompareTag("EnemyShot"))
        {
            information.life -= collision.gameObject.GetComponent<InformationEnemyShot>().damage;
        }
    }
}
