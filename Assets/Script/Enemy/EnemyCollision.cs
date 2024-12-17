using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    //Asteroid information
    InformationEnemy information;
    //Sprite of the asteroid
    SpriteRenderer spriteRenderer;
    private bool isDie = false;
   
    private void Start()
    {
        //Get asteroid information
        information = GetComponent<InformationEnemy>();
        //Get sprite renderer
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    IEnumerator changeColor()
    {
        //Wait and return the color 
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }
    //Collision with other 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enemy collision");
        //Collision with shot lose life
        if (collision.gameObject.CompareTag("Shot"))
        {
            //Change the color to red and get damage
            spriteRenderer.color = Color.red;
            information.life -= collision.gameObject.GetComponent<InformationShot>().damage;
            //Change the color to black
            StartCoroutine(changeColor());

        }
        //If the asteroid die delete this
        if (information.life <= 0)
        {
            if (!isDie)
            {   
                isDie = true;
            }
            
            Destroy(gameObject);
        }
    }
}
