using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShot : MonoBehaviour
{
    //Type of new shot
    public int typeOfShot;

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
    public const string SHOTNAME = "Shot/Shot";
    //Ubication of the prefab lucky shot
    public const string SHOTNAMELUCKY = "Shot/LuckyShot";
    //Comprobe is you can shooting
    private bool isShooting = true;
    //The game object we goint to create
    private GameObject prefav;
    //Wait time of the new shot
    private float waitTime = InformationLevelOfShotting.Shooting();
    //Comprobe if can create a shot
    public bool isEnable;
    //AudioSource
    private AudioSource audio;

    private void Start()
    {
        try
        {
            audio = GetComponent<AudioSource>();
        }
        catch (System.Exception) { 
        
        }
       
    }

    private void Update()
    {
        
        //Comprobe if this Create shot is enable
        if (!isEnable || !InformationShot.isShooting)
            return;
        //If the player use the mouse he shooting a shot
        if (Input.GetKey(KeyCode.Mouse0) && isShooting && Time.timeScale!=0)
        {
            //Comprove the time
            waitTime = InformationLevelOfShotting.Shooting();
            //Stop shooting
            isShooting = false;
            StartCoroutine(newShooting());
            //If is lucky create a lucky shot if not a normal shot
            if (InformationPowerUpPlayer.IsLucky())
            {
                //Create a lucky shot
                createLuckyShot();
            }
            else
            {
                //Create a normal shot
                createShot();
            }

            //Create the type of shot
            prefav.GetComponent<InformationShot>().type = typeOfShot;
            prefav.GetComponent<InformationShot>().angleZ = transform.parent.rotation.eulerAngles.z;
            //Play the audio
            if (audio != null && !audio.isPlaying)
            {
                audio.Play();
            }
        }   
    }

    IEnumerator newShooting()
    {
        //Wait the new shoot
        yield return new WaitForSeconds(waitTime);
        isShooting = true;

    }

    public void createShot()
    {
        //Create the shot
        prefav = Instantiate(Resources.Load<GameObject>(SHOTNAME), this.transform.position, Quaternion.identity);


    }

    public void createLuckyShot()
    {
        //Create the shot luckyShot
        prefav = Instantiate(Resources.Load<GameObject>(SHOTNAMELUCKY), this.transform.position, Quaternion.identity);
    }
}
