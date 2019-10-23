using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    void Update()
    {
        // if left button pressed...
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
              if (hit.collider.GetComponent<ClickableObject>())
                {
                    var clickedObject = hit.collider.GetComponent<ClickableObject>();
                    clickedObject.Clicked();
                }
            }
        }
    }
}
