using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyChange : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Update()
    {
        //Update the value of the money
        text.text = InformationPowerUpPlayer.moneyActually.ToString();
    }
}
