using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetLaser : MonoBehaviour
{
   //Get the imagen to has been change
    public Image image;
    //The diferent images
    public Sprite sprite1;
    public Sprite sprite2;
    //Text indicate if the laser is activate or not
    public TextMeshProUGUI textLaser;
    // Update is called once per frame
    void Update()
    {
        if(!InformationPowerUpPlayer.isChangeLaser)
            return;

        //Devolve the color
        image.color = Color.white;
        //Change the sprite
        if (InformationPowerUpPlayer.islaserBeam)
        {
            textLaser.text = "Laser enable";
            image.sprite = sprite1;
        }
        else
        {
            textLaser.text = "Laser disable";
            image.sprite = sprite2;
        }
        

    }

}
