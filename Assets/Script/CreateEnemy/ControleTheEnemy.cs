using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ControleTheEnemy : MonoBehaviour
{

    private bool isNewEnemy = false;

    public AudioSource audio;
    public AudioClip[] audioPlayableAssets;
    private bool sound = true;
    private bool isBoss = false;


    // Update is called once per frame
    void Update()
    {
        if(InformationCreateEnemy.bossLife != 0 && !isNewEnemy)
        {
            isNewEnemy = true;
            StartCoroutine(createEnemy());
        }

        if (InformationCreateEnemy.enemyLive != 0 || InformationCreateEnemy.bossLife != 0)
            return;
        InformationCreateEnemy.waves++;
        if (InformationCreateEnemy.waves % 5 != 0)
        {
            if (isBoss)
            {
                isBoss = false;
                audio.clip = sound ? audioPlayableAssets[0] : audioPlayableAssets[1];
                audio.Play();
            }
            //Create any random amount of enemies
            InformationCreateEnemy.enemyLive = Random.Range((InformationCreateEnemy.waves / 6) + 3, (InformationCreateEnemy.waves / 3) + 5);
            InformationCreateEnemy.enemyToMade = InformationCreateEnemy.enemyLive;

        }
        else
        {
            isBoss = true;
            sound = !sound;
            audio.clip = audioPlayableAssets[2];
            audio.Play();
            InformationCreateEnemy.bossToMade++;
            InformationCreateEnemy.bossLife++;
        }
        
    }

    private IEnumerator createEnemy()
    {
        InformationCreateEnemy.enemyToMade++;
        InformationCreateEnemy.enemyLive++;
        yield return new WaitForSeconds(Random.Range(5, 30));
        isNewEnemy = false;

    }
}
