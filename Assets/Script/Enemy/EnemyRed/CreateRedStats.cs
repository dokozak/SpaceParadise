using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRedStats : MonoBehaviour
{
    private InformationEnemy information;
    // Start is called before the first frame update
    void Start()
    {
        information = GetComponent<InformationEnemy>();
        information.life = 10 + InformationCreateEnemy.levelOfDificult * 3;
    }
}
