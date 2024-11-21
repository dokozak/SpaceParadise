using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyAllIsEnable : MonoBehaviour
{
    private bool isMax = false;

    // Update is called once per frame
    void Update()
    {
        //End this
        if (isMax)
            return;
        //Get all values
        int values = InformationPowerUpPlayer.emergencyButtonLevel + InformationPowerUpPlayer.shotUpLevel +
            InformationPowerUpPlayer.powerUpLevel + InformationPowerUpPlayer.luckyLevel + InformationPowerUpPlayer.lifeLevel +
            InformationPowerUpPlayer.barrelLevel + InformationPowerUpPlayer.fixBarrelLevel + InformationPowerUpPlayer.shotVelocityLevel;

        //The level max
        if(values == 8 * 5)
        {
            //You can use the laser
            InformationPowerUpPlayer.isChangeLaser = true;
            isMax = true;
        }


    }
}
