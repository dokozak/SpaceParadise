using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleTheEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Default values
        InformationCreateEnemy.waves = 0; 
        InformationCreateEnemy.enemyLive = 0;
        InformationCreateEnemy.enemyToMade = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (InformationCreateEnemy.enemyLive != 0)
            return;

        //Create any random amount of enemies
        InformationCreateEnemy.enemyLive = Random.Range((InformationCreateEnemy.waves / 6) + 3, (InformationCreateEnemy.waves / 3) + 5);
        InformationCreateEnemy.enemyToMade = InformationCreateEnemy.enemyLive;
        InformationCreateEnemy.waves++;
    }
}
