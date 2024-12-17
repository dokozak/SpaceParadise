using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeleteBoss : MonoBehaviour
{
    private string ruteOfPowerUp = "PowerUp/PowerUp";
    private void OnDestroy()
    {
        if (InformationPlayer.theGameEnd)
            return;
        Instantiate(Resources.Load(ruteOfPowerUp), transform.position, Quaternion.identity);
        InformationCreateEnemy.bossLife--;
        InformationCreateEnemy.levelOfDificult++;
    }
}
