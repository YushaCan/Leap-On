using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraAngle : MonoBehaviour
{
    public ScriptableInt distanceToCenter;
    public ScriptableVector3 midDistanceForCamera;
    int temporaryDistance;
    public Camera mainCam;
    private void Update()
    {
        FocusOnTheMid();
        ArrangeCameraDistance();
    }
    void ArrangeCameraDistance()
    {
        mainCam.DOOrthoSize(midDistanceForCamera.value.magnitude * 3f, 2.5f);
    }
    void FocusOnTheMid()
    {
        mainCam.transform.position = new Vector3(midDistanceForCamera.value.x, midDistanceForCamera.value.y, mainCam.transform.position.z);
    }
}