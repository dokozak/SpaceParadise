using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAsteroid : MonoBehaviour
{
    //Comprobe if this object is creator or not
    public bool isCreator;
    //Type of creator
    public int typeOfCreator;
    //Type of creator
    private const int TOP = 0;
    private const int BOTTOMRIGHT = 1;
    private const int BOTTOMLEFT = 2;
    //Rute of the asteroid
    private const string ASTEROIDHUGE1 = "Asteroid/AsteroidHuge1";
    private const string ASTEROIDHUGE2 = "Asteroid/AsteroidHuge2";
    private const string ASTEROIDHUGE3 = "Asteroid/AsteroidHuge3";
    private const string ASTEROIDBIG1 = "Asteroid/AsteroidBig1";
    private const string ASTEROIDBIG2 = "Asteroid/AsteroidBig2";
    private const string ASTEROIDBIG3 = "Asteroid/AsteroidBig3";
    private const string ASTEROIDBIG4 = "Asteroid/AsteroidBig4";
    private const string ASTEROIDMEDIUM1 = "Asteroid/AsteroidMedium1";
    private const string ASTEROIDMEDIUM2 = "Asteroid/AsteroidMedium2";
    private const string ASTEROIDMEDIUM3 = "Asteroid/AsteroidMedium3";
    private const string ASTEROIDMEDIUM4 = "Asteroid/AsteroidMedium4";
    private const string ASTEROIDMEDIUM5 = "Asteroid/AsteroidMedium5";
    //Matriz of the asteroid
    private string[] big = {ASTEROIDBIG1, ASTEROIDBIG2, ASTEROIDBIG3, ASTEROIDBIG4};
    private string[] huge = {ASTEROIDHUGE1, ASTEROIDHUGE2, ASTEROIDHUGE3};
    private string[] medium = {ASTEROIDMEDIUM1, ASTEROIDMEDIUM2, ASTEROIDMEDIUM3, ASTEROIDMEDIUM4, ASTEROIDMEDIUM5};
    public void CreateChild(int x)
    {
        //Depend of the type of the pather meteorite
        switch (x)
        {
            //Create the asteroid
            case InformationAsteroid.TYPEHUGE:
                createAsteroid(typeOfCreator, big);
                break;
            case InformationAsteroid.TYPEBIG:
                createAsteroid(typeOfCreator, medium);
                break;
        }
    }

    public void Update()
    {
        if (!isCreator)
            return;
    }


    public void createAsteroid(int type, string[] arrayAsteroid)
    {
        //Transform pather
        Transform pather = GetComponentInParent<Transform>();
        //Create the game object
        GameObject gameObject = Instantiate(
                    Resources.Load<GameObject>(arrayAsteroid[Random.Range(0, arrayAsteroid.Length)]),
                    new Vector3(transform.position.x, transform.position.y, transform.position.z),
                    Quaternion.identity);
        //Information of the asteroid
        InformationAsteroid information = gameObject.GetComponent<InformationAsteroid>();
        information.isChild = true;
        //Movement of the asteroid child
        float[] movement = null;
        //Depend of the type the move is any or other
        switch (type) 
        {
            case TOP:
                movement = angle(0, 1, pather.rotation.eulerAngles.z);
                break;
            case BOTTOMRIGHT:
                movement = angle(1, -1, pather.rotation.eulerAngles.z);
                break;
            case BOTTOMLEFT:
                movement = angle(-1, -1, pather.rotation.eulerAngles.z);
                break;
        }
        //Vinculate the values
        information.movementX = movement[0];
        information.movementY = movement[1];
        information.isInvencible = true;
    }


    //Change the movement of the shot
    public float[] angle(float x, float y, float z)
    {
        //Radiant angle
        float radiantAngle = z * Mathf.Deg2Rad;

        //Change the position x and y
        float x2 = x * Mathf.Cos(radiantAngle) - y * Mathf.Sin(radiantAngle);
        float y2 = x * Mathf.Sin(radiantAngle) + y * Mathf.Cos(radiantAngle);

        return new float[] { x2, y2 };
    }
}
