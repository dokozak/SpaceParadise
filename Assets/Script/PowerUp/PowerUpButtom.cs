using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpButtom : MonoBehaviour
{
    public RectTransform outSide;
    public RectTransform[] powerUpButton;
    private InformationPlayer information;
    private void Start()
    {
        information = GameObject.FindGameObjectWithTag("Player").GetComponent<InformationPlayer>();
    }
    public void MoreLifeMax()
    {
       information.maxLife += 15;
       information.actuallyLife += 15;
        MoveThePowerUp();
    }

    public void HealthLife()
    {
        if(information.actuallyLife+30 >= information.maxLife)
        {
            information.actuallyLife = information.maxLife;
        }
        else
        {
            information.actuallyLife += 30;
        }
        MoveThePowerUp();
    }

    public void BarrelOverheating()
    {
        information.maxHotBarrel += 1;
        information.actuallyHotBarrel = 0;
        MoveThePowerUp();
    }
    public void ShotSpeedUp()
    {
    InformationLevelOfShotting.MoreShotSpeed += 1;
    MoveThePowerUp();
    }

    public void MoreShoting()
    {
    InformationLevelOfShotting.MoreShooting+= 1;
    MoveThePowerUp();
    }

    public void MoveThePowerUp()
    {
        Time.timeScale = 1;
        for (int i = 0; i < powerUpButton.Length; i++)
        {
            powerUpButton[i].position = outSide.position;
        }
    }
        
    
}
