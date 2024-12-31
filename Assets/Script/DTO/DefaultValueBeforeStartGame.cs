using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultValueBeforeStartGame : MonoBehaviour
{
    private void Awake()
    {
        InformationCreateEnemy.waves = 0;
        InformationCreateEnemy.enemyToMade = 0;
        InformationCreateEnemy.enemyLive = 0;
        InformationCreateEnemy.bossToMade = 0;
        InformationCreateEnemy.bossLife = 0;
        InformationCreateEnemy.levelOfDificult = 0;
        InformationPlayer.theGameEnd = false;
        InformationShot.isShooting = true;
        Time.timeScale = 1f;
        InformationLevelOfShotting.MoreShooting = 0;
        InformationLevelOfShotting.MoreShotSpeed = 0;
        Stadistics.enemiesKilledInThisGame = 0;
        Stadistics.bossesDeletedInThisGame = 0;
        Stadistics.wavesInThisGame = 0;

        Destroy(gameObject);
    }
}
