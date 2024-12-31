using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeleteEnemy : MonoBehaviour
{

    private string ruteOfPowerUp = "PowerUp/PowerUp";
    private string ruteOfExplosion = "Explosion/Explosions";
    private const int PROBABILITY = 20;

    private void OnDestroy()
    {
        InformationCreateEnemy.enemyLive--;
        Stadistics.enemiesKilledInThisGame++;
        if (InformationPlayer.theGameEnd)
        {
            
            return;
        }else if (InformationCreateEnemy.bossLife != 0)
        {
            Instantiate(Resources.Load(ruteOfExplosion), transform.position, Quaternion.identity);
            return;
        }


        Instantiate(Resources.Load(ruteOfExplosion), transform.position, Quaternion.identity);
        if (Random.Range(0, 101) <= PROBABILITY)
        Instantiate(Resources.Load(ruteOfPowerUp), transform.position, Quaternion.identity);
       
    }
}
