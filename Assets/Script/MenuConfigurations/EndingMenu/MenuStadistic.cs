using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuStadistic : MonoBehaviour
{
    public TextMeshProUGUI textRuby;
    public TextMeshProUGUI textStadistics;
    public RectTransform posicion;
    public bool isEnding = false;
    // Update is called once per frame
    void Update()
    {
        if (!InformationPlayer.theGameEnd || isEnding)
            return;

        transform.position = posicion.position;
        if ((InformationPowerUpPlayer.moneyActually += InformationCreateEnemy.levelOfDificult) >= 100)
            InformationPowerUpPlayer.moneyActually = 99;
        if (Stadistics.recordOfTimeWaves < InformationCreateEnemy.waves-1)
            Stadistics.recordOfTimeWaves =InformationCreateEnemy.waves;
        Stadistics.bossesDeleted += InformationCreateEnemy.levelOfDificult;
        Stadistics.enemiesKilled += Stadistics.enemiesKilledInThisGame;

        if(InformationCreateEnemy.levelOfDificult == 0)
            textRuby.text = "You have not won any ruby";
        else     
            textRuby.text = "You have won " + InformationCreateEnemy.levelOfDificult + ((InformationCreateEnemy.levelOfDificult == 1) ?  " a ruby":" rubies");


        textStadistics.text = "Enemy has been killed: " + Stadistics.enemiesKilledInThisGame +"\n"
                             + "Boss has been killed: " + InformationCreateEnemy.levelOfDificult + "\n"
                             +"Waves you have survived: " + (InformationCreateEnemy.waves-1) + "\n";
        Time.timeScale = 0;
        Stadistics.dieTimes++;
        isEnding = true;
    }
}
