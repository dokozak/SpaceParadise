using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebegLoga : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(InformationCreateEnemy.enemyLive + ": Enemy life, " + InformationCreateEnemy.enemyToMade + ": Enemy to made " + InformationCreateEnemy.bossLife + ": Boss to life"+ InformationCreateEnemy.waves + ": Wave"); 
    }
}
