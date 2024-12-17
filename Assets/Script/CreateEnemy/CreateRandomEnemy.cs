
using System.Collections;
using UnityEngine;

public class CreateRandomEnemy : MonoBehaviour {
    //Path of the enemy
    private const string CREATEREDENEMY = "Enemy/NormalEnemy/EnemyRedShip";
    private const string CREATEGREENENEMY = "Enemy/NormalEnemy/EnemyGreenShip";
    private const string CREATEBLUEENEMY = "Enemy/NormalEnemy/EnemyBlueShip";
    private const string CREATEPURPLEENEMY = "Enemy/NormalEnemy/EnemyPurpleShip";
    private bool isCreating = false;
    // Update is called once per frame
    private void Update()
    {
        if (InformationCreateEnemy.enemyToMade == 0 || isCreating)
            return;

        InformationCreateEnemy.enemyToMade--;
        isCreating = true;
        StartCoroutine(getNewEnemy());



    }

    IEnumerator getNewEnemy()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
        switch(Random.Range(0, 4))
        {
            case 0:
                Instantiate(Resources.Load<GameObject>(CREATEREDENEMY), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);
                break;
            case 1:
                Instantiate(Resources.Load<GameObject>(CREATEGREENENEMY), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);
                break;
            case 2:
                Instantiate(Resources.Load<GameObject>(CREATEBLUEENEMY), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);
                break;
            case 3:
                Instantiate(Resources.Load<GameObject>(CREATEPURPLEENEMY), new Vector3(transform.position.x, transform.position.y, transform.position.z + 10), Quaternion.identity);
                break;
        }
        
        isCreating = false;


    }
}
