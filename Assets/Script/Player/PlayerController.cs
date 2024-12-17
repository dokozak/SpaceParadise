using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //The information player
    InformationPlayer information;
    private Camera camera;
    private float width, height;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        height = camera.orthographicSize;
        width = height * camera.aspect;
        //Get the information player
        information = GetComponent<InformationPlayer>();
        information.maxLife = InformationPowerUpPlayer.GetLife();
        information.emergencyButton = InformationPowerUpPlayer.emergencyButton();
        information.actuallyLife = information.maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        int valor1 = (Input.GetAxis("Horizontal") < 0) ? -1: 1;
        int valor2 = (Input.GetAxis("Vertical") < 0) ? -1 : 1;
        //Get the axis
        float x = (transform.position.x + valor1 < camera.transform.position.x - width 
            || transform.position.x + valor1 > camera.transform.position.x + width) ? 0 : Input.GetAxis("Horizontal");
        float y = (transform.position.y + valor2 < camera.transform.position.y - height 
            || transform.position.y + valor2 > camera.transform.position.y + height) ? 0 : Input.GetAxis("Vertical");
        //Move the ship
        this.transform.position = new Vector3(this.transform.position.x + x * Time.deltaTime* information.velocity, this.transform.position.y + y * Time.deltaTime * information.velocity, this.transform.position.z);
    }

}
