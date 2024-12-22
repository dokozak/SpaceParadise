using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionCreateShot : MonoBehaviour
{
    //Type of new shot
    public int typeOfShot;
    //Comprobe if can create a shot
    public bool isEnable;
    //Type of shotting
    public const int SHOTUP = 0;
    public const int SHOTUPRIGHT = 1;
    public const int SHOTRIGHT = 2;
    public const int SHOTDOWNRIGHT = 3;
    public const int SHOTDOWN = 4;
    public const int SHOTDOWNLEFT = 5;
    public const int SHOTlEFT = 6;
    public const int SHOTUPLEFT = 7;
    //Ubication of the prefab shot
    public const string SHOTNAME = "Enemy/EnemyShot/EnemyShot";
    //Comprobe is you can shooting
    private bool isShooting = true;
    //Wait time of the new shot
    private float waitTime = 0.1f;
    //The game object we goint to create
    private GameObject prefav;


    private void Update()
    {

        //Comprobe if this Create shot is enable
        if (!isEnable)
            return;
        //If the player use the mouse he shooting a shot
        if (isShooting)
        {
            //Stop shooting
            isShooting = false;
            StartCoroutine(newShooting());
            //Create the shot
            prefav = Instantiate(Resources.Load<GameObject>(SHOTNAME), this.transform.position, Quaternion.identity);
            //Create the type of shot
            prefav.GetComponent<InformationEnemyShot>().type = typeOfShot;
        }
    }

    IEnumerator newShooting()
    {
        //Wait the new shoot
        yield return new WaitForSeconds(waitTime);
        isShooting = true;

    }
}
