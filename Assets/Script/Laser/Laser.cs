using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    RaycastHit2D raycastdetector;
    public LineRenderer Linea;
    public Transform tr;
    private float largoDelLaser = 5f;
    private float anchoDelCollider = 1.1f;

    private void Update()
    {
        Linea.SetPosition(0, (Vector2)tr.position + (Vector2)tr.up * (anchoDelCollider / 2));
        Linea.SetPosition(1, (Vector2)tr.position + (Vector2)tr.up * (largoDelLaser));

        raycastdetector = Physics2D.Raycast
            (tr.position + tr.up * anchoDelCollider / 2
            , tr.up, largoDelLaser - anchoDelCollider / 2);

        if (raycastdetector.collider != null && raycastdetector.collider.gameObject.tag.Equals("Enemy"))
        {
            Linea.SetPosition(1, raycastdetector.point);
        }
    }
}
