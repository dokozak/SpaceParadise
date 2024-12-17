using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LifeProgressBar : MonoBehaviour
{
    public Image imagenSlider;
    public TextMeshProUGUI text;
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
        float slider = (float)information.actuallyLife / information.maxLife;
        //Change the progress bar
        imagenSlider.fillAmount = slider;

        //Change the information for the player
        text.SetText(information.actuallyLife + "/" + information.maxLife);

    }
}
