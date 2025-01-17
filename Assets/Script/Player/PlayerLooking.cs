using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLooking : MonoBehaviour
{
    private void Update()
    {
        if(Time.timeScale!= 0)
        looking();
    }
    void looking()
    {
        // Get the mouse position
        Vector3 MousePosition = Input.mousePosition;
        MousePosition.z = Camera.main.transform.position.z;

        // Convert mouse position to world coordinates
        Vector3 direction = Camera.main.ScreenToWorldPoint(MousePosition) - transform.position;
        direction.z = 0;

        // Rotate the direction to mouse
        transform.right = direction;
        transform.Rotate(0, 0, -90);

    }
}
