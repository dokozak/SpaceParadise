using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    //All infomation of the shot
    private InformationEnemyShot information;
    //
    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        //Get the information
        information = GetComponent<InformationEnemyShot>();
        //Movement of the shot
        switch (information.type)
        {
            case CreateEnemyShot.SHOTDOWN:
                angle(0, -information.movement, information.angleZ);
                break;
            case CreateEnemyShot.SHOTUP:
                angle(0, information.movement, information.angleZ);
                break;
            case CreateEnemyShot.SHOTlEFT:
                angle(-information.movement, 0, information.angleZ);
                break;
            case CreateEnemyShot.SHOTRIGHT:
                angle(information.movement, 0, information.angleZ);
                break;
            case CreateEnemyShot.SHOTUPRIGHT:
                angle(information.movement * 0.7f, information.movement * 0.7f, information.angleZ);
                break;
            case CreateEnemyShot.SHOTUPLEFT:
                angle(-information.movement * 0.7f, information.movement * 0.7f, information.angleZ);
                break;
            case CreateEnemyShot.SHOTDOWNLEFT:
                angle(-information.movement * 0.7f, -information.movement * 0.7f, information.angleZ);
                break;
            case CreateEnemyShot.SHOTDOWNRIGHT:
                angle(information.movement * 0.7f, -information.movement * 0.7f, information.angleZ);
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        //Transformation of the shot
        if (!renderer.isVisible)
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
        information.movementX = (x * Mathf.Cos(radiantAngle) - y * Mathf.Sin(radiantAngle)) * information.speed * information.velocity;
        information.movementY = (x * Mathf.Sin(radiantAngle) + y * Mathf.Cos(radiantAngle)) * information.speed * information.velocity;
    }
}
