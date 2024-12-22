using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IntroductionFinalMenu : MonoBehaviour
{
    public TextMeshProUGUI textRuby;
    public TextMeshProUGUI textStadistics;
    public RectTransform posicion;
    public bool isEnding = false;
    // Update is called once per frame
    void Update()
    {
        if (!InformationPlayer.theGameEnd || isEnding)
            return;

        transform.position = posicion.position;
        textRuby.text = "You end the tutorial";
        textStadistics.text = "Congratulation you complete the tutorial";
        Time.timeScale = 0;
        isEnding = true;
    }
}
