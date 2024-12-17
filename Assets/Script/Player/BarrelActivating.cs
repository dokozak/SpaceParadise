using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelActivating : MonoBehaviour
{
    private InformationPlayer information;
    private void Start()
    {
        information = GetComponent<InformationPlayer>();

        for (int i = 0; i < InformationPowerUpPlayer.barrel(); i++)
        {
            information.barrel[i].isEnable = true;
        }
    }

}
