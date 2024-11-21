using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenu : MonoBehaviour
{
    //Menu who we are move
    public GameObject panelChild;
    //Menu father who we are disable
    public GameObject panelFather;
    //Position for the panel child
    private Vector3 fatherVector;
    //Position for the panel father
    private Vector3 childVector;
    //Time at which the panel changed
    private float time = 0.5f;
    public bool isFather = true;

    // Start is called before the first frame update
    void Start()
    {
        if (isFather)
        {
            //Get de values
            fatherVector = new Vector3(panelFather.transform.position.x, panelFather.transform.position.y, panelFather.transform.position.z);
            childVector = new Vector3(panelChild.transform.position.x, panelChild.transform.position.y, panelChild.transform.position.z);
        }
        else
        {
            childVector = new Vector3(panelFather.transform.position.x, panelFather.transform.position.y, panelFather.transform.position.z);
            fatherVector = new Vector3(panelChild.transform.position.x, panelChild.transform.position.y, panelChild.transform.position.z);
        }
        
    }


    IEnumerator changeMenu()
    {
        //Time has been elapsed
        float timeElapsed = 0f;
        //Change the panels
        panelFather.SetActive(false);
        panelChild.SetActive(true);
        while (timeElapsed < time)
        {
            //Move the child panel
            panelChild.transform.position = Vector3.Lerp(childVector, fatherVector, timeElapsed / time);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        //The final move panels
        panelFather.transform.position = childVector;
        panelChild.transform.position = fatherVector;

    }


    public void ButtomSubMenu()
    {
        StartCoroutine(changeMenu());
    }
}
