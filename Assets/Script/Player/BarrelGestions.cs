using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarrelGestions : MonoBehaviour
{
    //Comprobe the barrel shot
    private float coldDown = InformationPowerUpPlayer.fixBarrel();
    private bool isColdDown = true;

    private bool isFirstTime = true;
    private float time = 0;
    //Information of the player
    private InformationPlayer information;

    // Start is called before the first frame update
    void Start()
    {
        information = GetComponent<InformationPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        CanShooting();
        barrelHot();
        StopShooting();
        barrelColdDown();
    }

    public void barrelHot()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.timeScale != 0 && InformationShot.isShooting)
        {
            if (isFirstTime && time == 0)
            {
                information.actuallyHotBarrel++;
            }
            if (time >= 0.2)
            {
                if (isFirstTime)
                {
                    isFirstTime = false;
                }
                else
                {
                    time -= 0.2f;
                    information.actuallyHotBarrel++;
                }
                
            }
            time += Time.deltaTime;
            
        }
        else
        {
            time = 0;
            isFirstTime = true;
        }
    }

    public void CanShooting()
    {
        if (information.actuallyHotBarrel <= 0)
        {
            InformationShot.isShooting = true;
        }
    }

    public void StopShooting()
    {
        if(information.actuallyHotBarrel >= information.maxHotBarrel + 2)
        {
            InformationShot.isShooting = false;
        }
    }

    public void barrelColdDown()
    {
        if (isColdDown && information.actuallyHotBarrel >= 0)
        {
            //ColdDown for the barrel
            information.actuallyHotBarrel--;
            isColdDown = false;
            StartCoroutine(ColdDown());
        }
    }
        
private IEnumerator ColdDown()
    {
        //Wait and new coldDown
        yield return new WaitForSeconds(coldDown);
        isColdDown = true;
    }
}
