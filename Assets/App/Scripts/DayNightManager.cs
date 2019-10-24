using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightManager : MonoBehaviour
{
    public GameObject dayNightCycle;

    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dayNightCycle.transform.Rotate(Vector3.right * Time.deltaTime * rotateSpeed);
    }
}
