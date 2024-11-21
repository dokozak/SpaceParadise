using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    //Information of the asteroid
    InformationAsteroid information;


    
    // Start is called before the first frame update
    void Start()
    {
        //Get the information of the asteroid
        information = GetComponent<InformationAsteroid>();
        //Random movement
        while (information.movementX == 0 && information.movementY == 0 && !information.isChild)
        {
            information.movementX = Random.Range(-1, 2);
            information.movementY = Random.Range(-1, 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Movement of the asteroid
        this.transform.position = new Vector3(transform.position.x + (information.movementX * InformationAsteroid.VELOCITY * Time.deltaTime), transform.position.y + (information.movementY * InformationAsteroid.VELOCITY * Time.deltaTime), transform.position.z);
        this.transform.Rotate(0, 0, 20*Time.deltaTime);
    }
}
