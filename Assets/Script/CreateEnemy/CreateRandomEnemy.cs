using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CreateRandomEnemy : MonoBehaviour
{
    private const string CREATEREDENEMY = "Enemy/NormalEnemy/EnemyRedShip";
    private const string CREATEGREENENEMY = "";
    private const string CREATEBLUEENEMY = "";
    private const string CREATEPURPLEENEMY = "";

    // Update is called once per frame
    private void Update()
    {
        if (InformationCreateEnemy.enemyToMade == 0)
            return;
        
            
        InformationCreateEnemy.enemyToMade--;
        Instantiate(Resources.Load<GameObject>(CREATEREDENEMY), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);


    }
}
