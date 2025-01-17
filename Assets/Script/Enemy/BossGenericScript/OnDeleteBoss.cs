using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeleteBoss : MonoBehaviour
{
    private string ruteOfPowerUp = "PowerUp/PowerUp";
    private string ruteOfExplosion = "Explosion/Explosions";


    private void OnDestroy()
    {
        if (InformationPlayer.theGameEnd)
            return;
        
        InformationCreateEnemy.bossLife--;
        InformationCreateEnemy.levelOfDificult++;
        Instantiate(Resources.Load(ruteOfPowerUp), transform.position, Quaternion.identity);
        Instantiate(Resources.Load(ruteOfExplosion), transform.position, Quaternion.identity);
    }
}
