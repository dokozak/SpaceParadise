using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class InformationPowerUpPlayer : MonoBehaviour
{
    //Money who have the player
    public static int moneyActually = 0;
    //Level of velocity of the shot
    public static int shotVelocityLevel = 1;
    //Level of velocity who the player shooting next time
    public static int shotUpLevel = 1;
    //Level of the live who have the player
    public static int lifeLevel = 1;
    //Times you can use the emergency Button
    public static int emergencyButtonLevel = 1;
    //Chance for the player to take double damage
    public static int luckyLevel = 1;
    //Increases the power up
    public static int powerUpLevel = 1;
    //Time it takes to fix the barrel
    public static int fixBarrelLevel = 1;
    //How many barrel have the player
    public static int barrelLevel = 1;
    //Gun of the player ship
    public static bool islaserBeam = false;
    //Comprobe if you can use the laser
    public static bool isChangeLaser = false;

    //Method who comprobe if the player has been lucky
    public static bool IsLucky()
    {
        //The lucky operation
        int AddLuckyValue = 5 * luckyLevel;
        if (AddLuckyValue >= Random.Range(0, 101))
            return true;
        return false;
    }

    //Life of the player
    public static int GetLife() 
    {
        // 75 live base + life for level 25
        return 75 + (lifeLevel * 25);
    
    }

    public static float ShotVelocitySpeed(int value)
    {
        return 0.125f + shotVelocityLevel * 0.010f + value * 0.0025f;
    }

    public static float ShotCreateTime(int value)
    {
        

        return 0.30f - shotUpLevel * 0.02f + value * 0.005f;
    }

    public static int emergencyButton()
    {
        return emergencyButtonLevel;
    }

    public static int powerUp()
    {
        return powerUpLevel;
    }

    public static float fixBarrel()
    {
       return 0.8f - fixBarrelLevel * 0.03f;
    }

    public static int barrel()
    {
        return barrelLevel;
    }

}
