using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid") || collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

}
