using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreBarrel : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;
    public bool isCompleted = false;
    // Update is called once per frame
    void Update()
    {
        //Stop the update
        if (isCompleted)
            return;

        switch (InformationPowerUpPlayer.barrelLevel)
        {
            case 5:
                isCompleted = true;
                image4.color = UnityEngine.Color.white;
                goto case 4;
            case 4:
                image3.color = UnityEngine.Color.white;
                goto case 3;
            case 3:
                image2.color = UnityEngine.Color.white;
                goto case 2;
            case 2:
                image1.color = UnityEngine.Color.white;
                break;
        }
    }
}
