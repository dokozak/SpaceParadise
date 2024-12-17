using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeleteEnemy : MonoBehaviour
{

    private InformationEnemy information;
    private string ruteOfPowerUp = "PowerUp/PowerUp";
    private const int PROBABILITY = 5;
    private void Start()
    {
        information  = GetComponent<InformationEnemy>();  
        
    }
    private void OnDestroy()
    {
        if (InformationPlayer.theGameEnd)
            return;

        if (Random.Range(0, 101) <= PROBABILITY)
        Instantiate(Resources.Load(ruteOfPowerUp), transform.position, Quaternion.identity);
        InformationCreateEnemy.enemyLive--;
        Stadistics.enemiesKilledInThisGame++;
    }
}
