using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPosition : MonoBehaviour
{
   public RectTransform position;

    private void Start()
    {
        this.transform.position = position.position;
    }
}
