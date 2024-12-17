using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WavesAndEmergencyButton : MonoBehaviour
{
    private InformationPlayer information;
    public TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
     information = GameObject.FindGameObjectWithTag("Player").GetComponent<InformationPlayer>();   
    }

    private void Update()
    {
        textMeshProUGUI.text = "Wave: " +InformationCreateEnemy.waves + "\n"+
                                "Safe button: " + information.emergencyButton;
    }
}
