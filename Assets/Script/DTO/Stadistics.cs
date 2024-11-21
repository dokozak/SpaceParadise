using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stadistics : MonoBehaviour 
{

    //Times who the player die
    private int dieTimes { get; set; } = 0;
    //Enemies who has been killer with the player
    private int enemiesKilled { get; set; } = 0;
    //Bosses who has been killer with the player
    private int bossesDeleted { get; set; } = 0;
    //Record of the plater survive
    private int recordOfTimeSurvive { get; set; } = 0;
    //Victories who have the player
    private int victories { get; set; } = 0;
    //Count of the money who the player get all game
    private int maxMoney { get; set; } = 0;

}
