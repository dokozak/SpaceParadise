using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //All infomation of the shot
    private InformationShot information;

    // Start is called before the first frame update
    void Start()
    {
        //Get the information
        information = GetComponent<InformationShot>();
        //Get the velocity level
        information.velocity = InformationPowerUpPlayer.ShotVelocitySpeed();
        //Movement of the shot
        switch (information.type)
        {
            case CreateShot.SHOTDOWN:
                angle(0, -information.movement, information.angleZ);
                break;
            case CreateShot.SHOTUP:
                angle(0, information.movement, information.angleZ);
                break;
            case CreateShot.SHOTlEFT:
                angle(-information.movement, 0, information.angleZ);
                break;
            case CreateShot.SHOTRIGHT:
                angle(information.movement, 0, information.angleZ);
                break;
            case CreateShot.SHOTUPRIGHT:
                angle(information.movement * 0.7f, information.movement * 0.7f, information.angleZ);
                break;
            case CreateShot.SHOTUPLEFT:
                angle(-information.movement * 0.7f, information.movement * 0.7f, information.angleZ);
                break;
            case CreateShot.SHOTDOWNLEFT:
                angle(-information.movement * 0.7f, -information.movement * 0.7f, information.angleZ);
                break;
            case CreateShot.SHOTDOWNRIGHT:
                angle(information.movement * 0.7f, -information.movement * 0.7f, information.angleZ);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Calcule the time life of the shot
        information.timeLife += Time.deltaTime;


        //Transformation of the shot
        if (information.timeLife > 5)
        {
            //End of life of the shot
            Destroy(this.gameObject);
        }

    }

    private void FixedUpdate()
    {
        //Move the shot
        this.transform.position = new Vector3(this.transform.position.x + (information.movementX * Time.fixedDeltaTime), this.transform.position.y + (information.movementY * Time.fixedDeltaTime), this.transform.position.z);

    }

    //Change the movement of the shot
    public void angle(float x, float y, float z)
    {
        //Radiant angle
        float radiantAngle = z * Mathf.Deg2Rad;

        //Change the position x and y
        information.movementX = (x * Mathf.Cos(radiantAngle) - y * Mathf.Sin(radiantAngle)) * InformationShot.speed * information.velocity;
        information.movementY = (x * Mathf.Sin(radiantAngle) + y * Mathf.Cos(radiantAngle)) * InformationShot.speed * information.velocity;
    }
}
