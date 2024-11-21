using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollisions : MonoBehaviour
{
    //Asteroid information
    InformationAsteroid information;
    //Sprite of the asteroid
    SpriteRenderer spriteRenderer;
    
   
    private void Start()
    {
        //Get asteroid information
        information = GetComponent<InformationAsteroid>();
        //Get sprite renderer
        spriteRenderer = GetComponent<SpriteRenderer>();
        //Start the coroutine
        StartCoroutine(invencible());
    }

    IEnumerator invencible()
    {
        //Wait to welcome to vencible
        yield return new WaitForSeconds(1f);
        information.isInvencible = false;
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
        Debug.Log("Asteroid collision");
        //Collision with shot lose life
        if (collision.gameObject.CompareTag("Shot"))
        {
            //Change the color to red and get damage
            spriteRenderer.color = Color.red;
            information.life -= collision.gameObject.GetComponent<InformationShot>().damage;
            //Change the color to white
            StartCoroutine(changeColor());
            
        }
        //Collision with other asteroid delete this asteroid
        if(collision.gameObject.CompareTag("Asteroid") && !information.isInvencible)
        {
            information.movementX *= -1;
            information.movementY *= -1;
            //Change the color to white
            StartCoroutine(changeColor());
        }


        //If the asteroid die delete this
        if (information.life <= 0)
        {
            if (information.typeOfAsteroid != InformationAsteroid.TYPEMEDIUM)
            {
                //Create the asteroid child
                for (int i = 0; i < information.createAsteroids.Length; i++)
                {
                    information.createAsteroids[i].CreateChild(information.typeOfAsteroid);
                }
            }
           
            //Destroy this gameobject
            Destroy(gameObject);
        }
    }
}
