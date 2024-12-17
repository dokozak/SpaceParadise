using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationPlayer : MonoBehaviour
{
    //Velocity of the ship movement
    public int velocity = 10;
    //Max life do player has
    public int maxLife = InformationPowerUpPlayer.GetLife();
    //Actually life do player have
    public int actuallyLife = InformationPowerUpPlayer.GetLife();
    //Max Hot Barre player can has
    public float maxHotBarrel = 100;
    //Actually hot barrel the player have
    public float actuallyHotBarrel = 0;
    //The barrel have the player
    public CreateShot[] barrel;

    public static bool theGameEnd = false;

    public int emergencyButton = 0;
}
