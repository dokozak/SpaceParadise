using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        this.transform.position = new Vector3(this.transform.position.x + (x * Time.deltaTime)*InformationPlayer.velocity, this.transform.position.y + (y * Time.deltaTime) * InformationPlayer.velocity, this.transform.position.z);
    }
}
