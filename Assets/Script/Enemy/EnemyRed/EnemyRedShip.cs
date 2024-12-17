using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRedShip : MonoBehaviour
{
    //information of enemy
    InformationEnemy information;
    //Speed
    private float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        //Get the information enemy
        information = GetComponent<InformationEnemy>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, speed * Time.deltaTime);

    }


}
