using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeleteMiniShip : MonoBehaviour
{
    private string ruteOfExplosion = "Explosion/Explosions";
    private void OnDestroy()
    {
        if (InformationPlayer.theGameEnd)
            return;
        Instantiate(Resources.Load(ruteOfExplosion), transform.position, Quaternion.identity);
    }
}
