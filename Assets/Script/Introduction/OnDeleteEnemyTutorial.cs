using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeleteEnemyTutorial : MonoBehaviour
{
    private string ruteOfPowerUp = "PowerUp/PowerUp";

    private void OnDestroy()
    {
        Instantiate(Resources.Load(ruteOfPowerUp), transform.position, Quaternion.identity);

    }
}
