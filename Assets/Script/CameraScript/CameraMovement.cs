using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMovement : MonoBehaviour
{

    private GameObject gameObject;
    private float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
       
        try
        {
            while (gameObject == null)
            {
                GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Enemy");
                gameObject = gameObjectArray[UnityEngine.Random.Range(0, gameObjectArray.Length)];
            }

            transform.position = Vector3.Lerp(transform.position, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
        catch (Exception e)
        {
            gameObject = null;
        }
    }
}
