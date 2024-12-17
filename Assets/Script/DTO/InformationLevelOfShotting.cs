using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationLevelOfShotting : MonoBehaviour
{
    public static int MoreShotSpeed = 0;
    public static int MoreShooting = 0;

    public static float ShotSpeed()
    {
        return InformationPowerUpPlayer.ShotVelocitySpeed(MoreShooting);
    }


    public static float Shooting()
    {
        return InformationPowerUpPlayer.ShotCreateTime(MoreShooting);
    }
}
