using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class ButtonBuyScript : MonoBehaviour
{
    IOInformation information;
    //Types of button
    private const int BUTTONMORESHOT = 0;
    private const int BUTTONMORELUCKY = 1;
    private const int BUTTONMORELIFE = 2;
    private const int BUTTONMOREMOREPOWERUP = 3;
    private const int BUTTONMOREMOREBARREL = 4;
    private const int BUTTONMORESAFEBUTTON = 5;
    private const int BUTTONMOREFIXBARREL = 6;
    private const int BUTTONMORESHOTSPEEDUP = 7;
    private const int BUTTONLASER = 8;
    //Prefab with the component
    public GameObject textPrefab;
    //Canva who has been add the float text
    public Canvas canvas;
    //Text of the information to player
    private const string TEXTINFORMATION = "You not have money";
    //The time of the text has
    private const int TIMEINFORMATION = 1;

    private void Start()
    {
        information = GetComponent<IOInformation>();
    }
    public void BUTTON_BuyUpgrades(int type)
    {
        //Change the shot
        if(BUTTONLASER == type)
        {
            ChangeLaser();
        }
        //Upgrade the level
        else
        switch (type)
        {
            case BUTTONMOREFIXBARREL:
                MoreFixBarrel();
                break;
            case BUTTONMORELIFE:
                MoreLife();
                break;
            case BUTTONMORELUCKY:
                MoreLucky();
                break;
            case BUTTONMOREMOREBARREL:
                MoreBarrel();
                break;
            case BUTTONMOREMOREPOWERUP:
                MorePowerUp();
                break;
            case BUTTONMORESAFEBUTTON:
                MoreSafeButton();
                break;
            case BUTTONMORESHOT:
                MoreShot();
                break;
            case BUTTONMORESHOTSPEEDUP:
                MoreShotSpeed();
                break;
        }
        information.SaveGame();
    }

    private void MoreShot()
    {
        //Level max
        if(InformationPowerUpPlayer.shotUpLevel == 5)
        {
            ShowFloatingText("You have reached the last level", 1);
        }
        else if(InformationPowerUpPlayer.moneyActually == 0)
        {
            ShowFloatingText("You not have money", 1);
        }
        else
        {
            //Upgrade the level
            InformationPowerUpPlayer.moneyActually--;
            InformationPowerUpPlayer.shotUpLevel++;
        }
       
    }

    private void MoreShotSpeed()
    {
        //Level max
        if (InformationPowerUpPlayer.shotVelocityLevel == 5)
        {
            ShowFloatingText("You have reached the last level", 1);
        }

        //If you not have money the play see a lavel
        else if (InformationPowerUpPlayer.moneyActually == 0)
        {
            ShowFloatingText("You not have money", 1);
        }
        else
        {
            //Upgrade the level
            InformationPowerUpPlayer.moneyActually--;
            InformationPowerUpPlayer.shotVelocityLevel++;
        }

    }
    private void MoreSafeButton()
    {
        //Level max
        if (InformationPowerUpPlayer.emergencyButtonLevel == 5)
        {
            ShowFloatingText("You have reached the last level", 1);
        }

        //If you not have money the play see a lavel
        else if (InformationPowerUpPlayer.moneyActually == 0)
        {
            ShowFloatingText("You not have money", 1);
        }
        else
        {
            //Upgrade the level
            InformationPowerUpPlayer.moneyActually--;
            InformationPowerUpPlayer.emergencyButtonLevel++;
        }

    }

    private void MorePowerUp()
    {
        //Level max
        if (InformationPowerUpPlayer.powerUpLevel == 5)
        {
            ShowFloatingText("You have reached the last level", 1);
        }

        //If you not have money the play see a lavel
        else if (InformationPowerUpPlayer.moneyActually == 0)
        {
            ShowFloatingText("You not have money", 1);
        }
        else
        {
            //Upgrade the level
            InformationPowerUpPlayer.moneyActually--;
            InformationPowerUpPlayer.powerUpLevel++;
        }

    }

    private void MoreBarrel()
    {
        //Level max
        if (InformationPowerUpPlayer.barrelLevel == 5)
        {
            ShowFloatingText("You have reached the last level", 1);
        }

        //If you not have money the play see a lavel
        else if (InformationPowerUpPlayer.moneyActually == 0)
        {
            ShowFloatingText("You not have money", 1);
        }
        else
        {
            //Upgrade the level
            InformationPowerUpPlayer.moneyActually--;
            InformationPowerUpPlayer.barrelLevel++;
        }

    }

    private void MoreLucky()
    {
        //Level max
        if (InformationPowerUpPlayer.luckyLevel == 5)
        {
            ShowFloatingText("You have reached the last level", 1);
        }

        //If you not have money the play see a lavel
        else if (InformationPowerUpPlayer.moneyActually == 0)
        {
            ShowFloatingText("You not have money", 1);
        }
        else
        {
            //Upgrade the level
            InformationPowerUpPlayer.moneyActually--;
            InformationPowerUpPlayer.luckyLevel++;
        }

    }


    private void MoreLife()
    {
        //Level max
        if (InformationPowerUpPlayer.lifeLevel == 5)
        {
            ShowFloatingText("You have reached the last level", 1);
        }

        //If you not have money the play see a lavel
        else if (InformationPowerUpPlayer.moneyActually == 0)
        {
            ShowFloatingText("You not have money", 1);
        }
        else
        {
            //Upgrade the level
            InformationPowerUpPlayer.moneyActually--;
            InformationPowerUpPlayer.lifeLevel++;
        }

    }

    private void MoreFixBarrel()
    {
        //Level max
        if (InformationPowerUpPlayer.fixBarrelLevel == 5)
        {
            ShowFloatingText("You have reached the last level", 1);
        }

        //If you not have money the play see a lavel
        else if (InformationPowerUpPlayer.moneyActually == 0)
        {
            ShowFloatingText("You not have money", 1);
        }
        else
        {
            //Upgrade the level
            InformationPowerUpPlayer.moneyActually--;
            InformationPowerUpPlayer.fixBarrelLevel++;
        }

    }

    private void ChangeLaser()
    {
        //Comprove if the player can use the laser
        if (InformationPowerUpPlayer.isChangeLaser)
        {
            //Change the laser
            InformationPowerUpPlayer.islaserBeam = !InformationPowerUpPlayer.islaserBeam;

        }
        else
        {
            //Diferent label
            switch (Random.Range(0, 6))
            {
                case 0:
                    ShowFloatingText("This is a bug? Really not", 2);
                    break;
                case 1:
                    ShowFloatingText("You can´t buy this, I know", 2);
                    break;
                case 2:
                    ShowFloatingText("Really men, try it again", 2);
                    break;
                case 3:
                    ShowFloatingText("The button is off", 2);
                    break;
                case 4:
                    ShowFloatingText("Is a secret shhhhh", 2);
                    break;
                case 5:
                    ShowFloatingText("Why not try to buy all", 2);
                    break;


            }

        }
    }

    public void ShowFloatingText(string text, float duration)
    {
        // instancie of prefab
        GameObject floatingText = Instantiate(textPrefab, canvas.transform);
        //Get the textMesh
        TextMeshProUGUI uiText = floatingText.GetComponent<TextMeshProUGUI>();

        // Change the text
        uiText.text = text;

        // Get the mouse position
        Vector3 mousePosition = Input.mousePosition;

        // Change the position of the text
        floatingText.transform.position = mousePosition;

        // Start coroutine
        StartCoroutine(AnimateFloatingText(floatingText, duration));
    }

    IEnumerator AnimateFloatingText(GameObject floatingText, float duration)
    {
        //The form of the text
        RectTransform rectTransform = floatingText.GetComponent<RectTransform>();
        //The start position
        Vector3 startPosition = rectTransform.position;
        //The final position
        Vector3 endPosition = startPosition + Vector3.up * 50;
        //Time has been passed
        float elapsedTime = 0f;

        // Animate the position and floating
        CanvasGroup canvasGroup = floatingText.GetComponent<CanvasGroup>();

        //If not have canva group add the canvas group
        if (canvasGroup == null)
        {
            canvasGroup = floatingText.AddComponent<CanvasGroup>();
        }
        //Destroy the item
        StartCoroutine(DestroyGameObject(floatingText, duration + 0.25f));
        
        //Time of the text
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;

            // Move the text
            rectTransform.position = Vector3.Lerp(startPosition, endPosition, t);

            // Change the opacity
            canvasGroup.alpha = Mathf.Lerp(1f, 0f, t);

            yield return null;
        }
    }
    IEnumerator DestroyGameObject(GameObject gameObject, float time)
    {
        // Destroy the gameObject
        Destroy(gameObject, time);
        yield return null;
    }

}
