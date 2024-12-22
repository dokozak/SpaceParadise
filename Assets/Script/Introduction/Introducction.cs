using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Introducction : MonoBehaviour
{
    public TextMeshProUGUI textTutorial;
    private int status = 0;
    private float time = 0;
    public GameObject firstEnemy, heatingEnemy, enemyShot, leftCreateShot;
    private ArrayList list = new ArrayList();
    public Transform positionOfShot;
    public GameObject player;
    public InformationPlayer InformationPlayer;
    public PowerUpButtomIntroduction powerUp;
    // Update is called once per frame
    void Update()
    {
        switch (status)
        {
            case 0:
                Presentation();
                break;
            case 1:
                Movement();
                break;
            case 2:
                shootingFirstEnemy();
                break;
            case 3:
                shootingHotEnemy();
                break;
                case 4:
                endShootingEnemyHot();
                    break;
                case 5:
                shootingEnemyShot();
                break;
            case 6:
                emergencyButton();
                break;
            case 7:
                endTutorial();
                break;




        }
    }

    private void Presentation()
    {
        if(time == 0) 
            textTutorial.text = "Welcome to the tutorial";
        time += Time.deltaTime;

        if(time > 3)
        {
            time = 0;
            status++;
        }

    }

    private void Movement()
    {
        if (time == 0)
            textTutorial.text = "Use A, W, S, D, to move the ship\nUse left clic to shooting";
        time += Time.deltaTime;

        if (time > 8)
        {
            time = 0;
            status++;
        }
    }

    private void shootingFirstEnemy()
    {
        if (time == 0) 
        {
            textTutorial.text = "This green ship is a enemy, try to kill him";
            firstEnemy = Instantiate(firstEnemy, Vector3.zero, Quaternion.identity);
        }
        time += Time.deltaTime;
        if (firstEnemy == null)
        {
            status++;
            time = 0;
        }
        
    }

    private void shootingHotEnemy()
    {
        if (time == 0)
        {
            player.AddComponent<BarrelGestions>();
            textTutorial.text = "Good, now kill this green enemy";
            heatingEnemy = Instantiate(heatingEnemy, Vector3.zero, Quaternion.identity);
        }
        time += Time.deltaTime;
        if (InformationPlayer.actuallyHotBarrel == InformationPlayer.maxHotBarrel + 2)
        {
            textTutorial.text = "If the barrel overheating bar fills up you will not be able to shoot until it is empty";
            heatingEnemy.GetComponent<InformationEnemy>().life = 50;
            status++;
            time = 0;
        }
    }

    private void endShootingEnemyHot()
    {
        
        if(heatingEnemy == null && time == 0)
        {
            textTutorial.text = "Get the chess to get a random item";
            time++;
        }

        if (powerUp.isActive)
        {
            time = 0;
            status++;
        }
            

    }

    private void shootingEnemyShot()
    {
        if (time == 0)
        {
            textTutorial.text = "See this enemy shot, try to touch";
            enemyShot = Instantiate(enemyShot, Vector3.zero, Quaternion.identity);
            time++;
        }

        if(enemyShot == null)
        {

            status++; 
            time = 0;
        }
       
    }


    private void emergencyButton()
    {
        if (time == 0)
        {
            textTutorial.text = "Were you touching a enemy shot you lose life, try to don´t touch more enemy shot";
            for (int y = 0; y < 100; y++) {
                list.Add(Instantiate(leftCreateShot, new Vector3(positionOfShot.position.x, positionOfShot.position.y-y, positionOfShot.position.z), Quaternion.identity));
            }
     
        }

        if(time > 3) {
            textTutorial.text = "Try to use 'E' to eliminate all the shot";
            player.AddComponent<EmergencyButton>();
            status++;
        }


        time += Time.deltaTime;

    }

    private void endTutorial()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(ending());
            
        }
    }
    IEnumerator ending()
    {
        yield return new WaitForSeconds(0.1f);
        InformationPlayer.theGameEnd = true;
    }
}
