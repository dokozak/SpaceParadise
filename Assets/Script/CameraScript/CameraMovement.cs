using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMovement : MonoBehaviour
{

    private GameObject NewgameObject = null;
    private float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
       
        try
        {
            while (NewgameObject == null)
            {
                GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Enemy");
                NewgameObject = gameObjectArray[UnityEngine.Random.Range(0, gameObjectArray.Length)];
            }

            transform.position = Vector3.Lerp(transform.position, new Vector3(NewgameObject.transform.position.x, NewgameObject.transform.position.y, 0), speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
        catch (Exception e)
        {
            NewgameObject = null;
        }
    }
}
