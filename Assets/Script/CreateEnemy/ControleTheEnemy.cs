using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleTheEnemy : MonoBehaviour
{

    private bool isNewEnemy = false;

    // Update is called once per frame
    void Update()
    {
        if(InformationCreateEnemy.bossLife != 0 && !isNewEnemy)
        {
            isNewEnemy = true;
            StartCoroutine(createEnemy());
        }

        if (InformationCreateEnemy.enemyLive != 0 || InformationCreateEnemy.bossLife != 0)
            return;
        InformationCreateEnemy.waves++;
        if (InformationCreateEnemy.waves % 5 != 0)
        {
            //Create any random amount of enemies
            InformationCreateEnemy.enemyLive = Random.Range((InformationCreateEnemy.waves / 6) + 3, (InformationCreateEnemy.waves / 3) + 5);
            InformationCreateEnemy.enemyToMade = InformationCreateEnemy.enemyLive;
        }
        else
        {
            InformationCreateEnemy.bossToMade++;
            InformationCreateEnemy.bossLife++;
        }
        
    }

    private IEnumerator createEnemy()
    {
        InformationCreateEnemy.enemyToMade++;
        InformationCreateEnemy.enemyLive++;
        yield return new WaitForSeconds(Random.Range(5, 30));
        isNewEnemy = false;

    }
}
