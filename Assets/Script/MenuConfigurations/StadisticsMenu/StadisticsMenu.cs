using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StadisticsMenu : MonoBehaviour
{
    public TextMeshProUGUI stadistics;
    // Start is called before the first frame update
    void Start()
    {
        stadistics.text = "Game played: " + Stadistics.dieTimes + "\n"+
                          "Enemies killed: "+ Stadistics.enemiesKilled + "\n"+
                          "Bosses killed: " + Stadistics.bossesDeleted + "\n"+
                          "Record of waves: " + Stadistics.recordOfTimeWaves + "\n";
    }

}
