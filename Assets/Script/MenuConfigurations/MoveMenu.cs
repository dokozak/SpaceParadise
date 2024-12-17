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

    // Start is called before the first frame update
    void Start()
    {
            //Get de values
            fatherVector = GameObject.FindGameObjectWithTag("FatherPosition").transform.position;
            childVector = GameObject.FindGameObjectWithTag("ChildPosition").transform.position;
    }


    IEnumerator changeMenu()
    {
        //Time has been elapsed
        float timeElapsed = 0f;
        //The final move panels
        panelFather.transform.position = childVector;

        while (timeElapsed < time)
        {
            //Move the child panel
            panelChild.transform.position = Vector3.Lerp(childVector, fatherVector, timeElapsed / time);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        //The final move panels
        panelChild.transform.position = fatherVector;

    }



    public void ButtomSubMenu()
    {
        StartCoroutine(changeMenu());
    }
}
