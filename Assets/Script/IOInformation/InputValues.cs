using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputValues : MonoBehaviour
{
    private IOInformation information;
    // Start is called before the first frame update
    void Start()
    {
        information = GetComponent<IOInformation>();
    }

    // Update is called once per frame
    void Update()
    {
        information.DataCharge();
        SceneManager.LoadScene("MenuScene");
        
    }
}
