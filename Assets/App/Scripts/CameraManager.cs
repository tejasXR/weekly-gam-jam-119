using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CameraPositions
{
    public Vector3 position;
    public Vector3 rotation;
}

public class CameraManager : MonoBehaviour
{

    public List<CameraPositions> cameraPositions = new List<CameraPositions>();
    public float cameraMovSpeed;
    private int currentCameraView = 0;


    private void OnEnable()
    {
        GameManager.TreeGrowCallback += ChangeCamera;
    }

    private void OnDisable()
    {
        GameManager.TreeGrowCallback -= ChangeCamera;
    }
    
    private void Update()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, cameraPositions[currentCameraView].position, Time.deltaTime * cameraMovSpeed);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, Quaternion.Euler(cameraPositions[currentCameraView].rotation), Time.deltaTime * cameraMovSpeed);
    }

    private void ChangeCamera()
    {
        if (currentCameraView < cameraPositions.Count)
        {
            currentCameraView++;
        }        
    }
}
