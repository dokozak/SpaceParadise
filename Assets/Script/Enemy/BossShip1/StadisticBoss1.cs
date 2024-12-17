using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StadisticBoss1 : MonoBehaviour
{
    InformationEnemy information;
    // Start is called before the first frame update
    void Start()
    {
        information = GetComponent<InformationEnemy>();
        information.life = 150 + InformationCreateEnemy.levelOfDificult * 20;

        for (int i = 0; i < 3; i++)
        {
            transform.GetChild(i).gameObject.GetComponent<InformationEnemy>().life = 50 + InformationCreateEnemy.levelOfDificult * 10;
        }

    }

}
