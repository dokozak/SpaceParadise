using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BarrelWarmingProgressBar : MonoBehaviour
{
    public Image imagenSlider;
    private InformationPlayer information;

    // Start is called before the first frame update
    void Start()
    {
        //Get the information of player
        information = GameObject.FindGameObjectWithTag("Player").GetComponent<InformationPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

        //Operation of the slider
        float slider = (float)information.actuallyHotBarrel / information.maxHotBarrel;
        //Comprobe the values
        if (slider > 1)
            slider = 1;
        //Change the progress bar
        imagenSlider.fillAmount = slider;

    }
}
