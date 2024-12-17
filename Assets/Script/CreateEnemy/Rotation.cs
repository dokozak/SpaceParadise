using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //Move the object who created the enemy
        transform.Rotate(0, 0, 1);
    }
}
