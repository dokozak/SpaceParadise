using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyButton : MonoBehaviour
{
    InformationPlayer information;

    private void Start()
    {
        information = GetComponent<InformationPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && information.emergencyButton > 0)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("EnemyShot");

            foreach (GameObject obj in objects)
            {
                Destroy(obj);
            }

            GameObject[] objects2 = GameObject.FindGameObjectsWithTag("SlowdownShot");

            foreach (GameObject obj in objects2)
            {
                Destroy(obj);
            }

            information.emergencyButton--;
        }
    }
}
