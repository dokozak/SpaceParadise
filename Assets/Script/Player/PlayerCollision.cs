using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //Information of player
    private InformationPlayer information;
    private SpriteRenderer spriteRenderer;
    //PowerUp 
    private RectTransform[] powerUpButton;
    private RectTransform[] positions;


    private void Start()
    {
        //Information player
        information = GetComponent<InformationPlayer>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        GameObject[] powerUpButton = GameObject.FindGameObjectsWithTag("PowerUpButton");
        this.powerUpButton = new RectTransform[powerUpButton.Length];
        for (int i = 0; i < powerUpButton.Length; i++)
        {
            this.powerUpButton[i] = powerUpButton[i].GetComponent<RectTransform>();
        }


        GameObject[] powerUpPositions = GameObject.FindGameObjectsWithTag("PowerUpPositions");
        this.positions = new RectTransform[powerUpPositions.Length];
        for (int i = 0; i < powerUpPositions.Length; i++)
        {
            this.positions[i] = powerUpPositions[i].GetComponent<RectTransform>();
        }
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.CompareTag("Asteroid"))
        {
            Debug.Log("The nave is collision");
        }
        if (collision.collider.CompareTag("EnemyShot"))
        {
            information.actuallyLife -= collision.gameObject.GetComponent<InformationEnemyShot>().damage;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyShot"))
        {
            information.actuallyLife -= collision.gameObject.GetComponent<InformationEnemyShot>().damage;
        }

        if (collision.gameObject.CompareTag("SlowdownShot"))
        {
            information.actuallyLife -= collision.gameObject.GetComponent<InformationEnemyShot>().damage;
            StartCoroutine(SlowdownShot());
        }

        if (collision.gameObject.tag.Equals("Chess"))
        {
            moveToPositions();
            Destroy(collision.gameObject);
        }
    }

    private IEnumerator SlowdownShot()
    {
        information.velocity = 5;
        spriteRenderer.color = Color.blue;

        yield return new WaitForSeconds(1);

        spriteRenderer.color = Color.white;
        information.velocity = 10;

    }


    private void moveToPositions()
    {
        Time.timeScale = 0;
        int[] notRepetibleNumber = (InformationPowerUpPlayer.powerUpLevel <= 2) ? new int[1] : (InformationPowerUpPlayer.powerUpLevel <= 4) ? new int[2] : new int[3];
        int notRepetibleNumberYouGet = 0;
        while (notRepetibleNumberYouGet < notRepetibleNumber.Length)
        {
            int randomNumber = Random.Range(1, InformationPowerUpPlayer.powerUpLevel + 1);
            for (int i = 0; i < notRepetibleNumber.Length; i++)
            {
                if (notRepetibleNumber[i] == 0)
                {
                    notRepetibleNumber[i] = randomNumber;
                    i = 99;
                    notRepetibleNumberYouGet++;

                }
                else if (notRepetibleNumber[i] == randomNumber)
                {
                    i = 99;
                }
            }

        }

        for (int i = 0; i < notRepetibleNumber.Length; i++)
        {
            Debug.Log(notRepetibleNumber[i] - 1 + "");
            powerUpButton[notRepetibleNumber[i] - 1].transform.position = positions[i].transform.position;
        }




    }
}
