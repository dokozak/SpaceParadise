using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomBoss : MonoBehaviour
{
    //Path of the enemy
    private const string CREATEBOSSSHIP1 = "Enemy/EnemyBoss/ChiperShip";
    private const string CREATEBOSSSHIP2 = "Enemy/BossEnemy/EnemyGreenShip";
    private const string CREATEBOSSSHIP3 = "Enemy/BossEnemy/EnemyBlueShip";
    private const string CREATEBOSSSHIP4 = "Enemy/BossEnemy/EnemyPurpleShip";
    private bool isCreating = false;
    // Update is called once per frame
    private void Update()
    {
        if (InformationCreateEnemy.bossToMade == 0 || isCreating)
            return;

        InformationCreateEnemy.bossToMade--;
        isCreating = true;
        StartCoroutine(getNewEnemy());



    }

    IEnumerator getNewEnemy()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
        switch (Random.Range(0, 1))
        {
            case 0:
                Instantiate(Resources.Load<GameObject>(CREATEBOSSSHIP1), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);
                break;
            case 1:
                Instantiate(Resources.Load<GameObject>(CREATEBOSSSHIP1), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);
                break;
            case 2:
                Instantiate(Resources.Load<GameObject>(CREATEBOSSSHIP1), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);
                break;
            case 3:
                Instantiate(Resources.Load<GameObject>(CREATEBOSSSHIP1), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);
                break;
        }

        isCreating = false;


    }
}
