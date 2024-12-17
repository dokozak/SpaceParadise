using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLose : MonoBehaviour
{
    InformationPlayer information;
    // Start is called before the first frame update
    void Start()
    {
        information = GetComponent<InformationPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(information.actuallyLife <= 0)
        {
            InformationPlayer.theGameEnd = true;

        }
    }
}
