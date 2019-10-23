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
    private void OnEnable()
    {
        GameManager.TreeGrowCallback += ChangeCamera;
    }

    private void OnDisable()
    {
        GameManager.TreeGrowCallback -= ChangeCamera;
    }

    public List<CameraPositions> cameraPositions = new List<CameraPositions>();

    private int currentCameraView = 0;

    private void Update()
    {
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, cameraPositions[currentCameraView].position, Time.deltaTime * 5F);
        Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, Quaternion.Euler(cameraPositions[currentCameraView].rotation), Time.deltaTime * 5F);
    }

    private void ChangeCamera()
    {
        if (currentCameraView < cameraPositions.Count)
        {
            currentCameraView++;
        }        
    }
}
