using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePurpleStats : MonoBehaviour
{
    private InformationEnemy information;
    // Start is called before the first frame update
    void Start()
    {
        information = GetComponent<InformationEnemy>();
        information.life = 20 + InformationCreateEnemy.levelOfDificult * 9;
    }
}
