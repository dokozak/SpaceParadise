using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    //Speed
    private float speed = 0.3f;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, speed * Time.deltaTime);

    }
}
