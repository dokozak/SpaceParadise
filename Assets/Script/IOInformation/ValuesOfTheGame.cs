using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ValuesOfTheGame
{
    //Money who have the player
    public int moneyActually = 0;
    //Level of velocity of the shot
    public int shotVelocityLevel = 0;
    //Level of velocity who the player shooting next time
    public int shotUpLevel = 0;
    //Level of the live who have the player
    public int lifeLevel = 0;
    //Times you can use the emergency Button
    public int emergencyButtonLevel = 0;
    //Chance for the player to take double damage
    public int luckyLevel = 0;
    //Increases healing of power up
    public int powerUpLevel = 0;
    //Time it takes to fix the barrel
    public int fixBarrelLevel = 0;
    //How many barrel have the player
    public int barrelLevel = 0;
    //Gun of the player ship
    public bool islaserBeam = false;
    //Comprobe if you can use the laser
    public bool isChangeLaser = false;
    //Times who the player die
    public int dieTimes = 0;
    //Enemies who has been killer with the player
    public int enemiesKilled = 0;
    //Bosses who has been killer with the player
    public int bossesDeleted = 0;
    //Record of the plater survive
    public int recordOfTimeWaves = 0;


    public ValuesOfTheGame() 
    {
    
    this.moneyActually = InformationPowerUpPlayer.moneyActually;
    this.shotVelocityLevel = InformationPowerUpPlayer.shotVelocityLevel;
    this.shotUpLevel = InformationPowerUpPlayer.shotUpLevel;
    this.lifeLevel = InformationPowerUpPlayer.lifeLevel;
    this.emergencyButtonLevel = InformationPowerUpPlayer.emergencyButtonLevel;
    this.luckyLevel = InformationPowerUpPlayer.luckyLevel;
    this.powerUpLevel = InformationPowerUpPlayer.powerUpLevel;
    this.fixBarrelLevel = InformationPowerUpPlayer.fixBarrelLevel;
    this.barrelLevel = InformationPowerUpPlayer.barrelLevel;
    this.islaserBeam = InformationPowerUpPlayer.islaserBeam;
    this.isChangeLaser = InformationPowerUpPlayer.isChangeLaser;
    this.dieTimes = Stadistics.dieTimes;
    this.enemiesKilled = Stadistics.enemiesKilled;
    this.bossesDeleted = Stadistics.bossesDeleted;
    this.recordOfTimeWaves = Stadistics.recordOfTimeWaves;



}
}
