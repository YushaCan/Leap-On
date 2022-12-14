using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateDistance : MonoBehaviour
{
    public Transform center, player;
    public ScriptableInt distanceToCenter;
    public ScriptableVector3 midDistanceForCamera;
    public ScriptableBool isGameOver;
    void Start()
    {
        // Distance to center at start position
        distanceToCenter.value = (int)(player.position - center.position).magnitude;
    }
    void Update()
    {
        if (!isGameOver.value)
        {
            DistanceCalculator();
        }
    }
    void DistanceCalculator()
    {
        // For farthest leap
        distanceToCenter.value = (int)(player.position - center.position).magnitude;
        // For camera
        midDistanceForCamera.value = (player.position - center.position) / 2;
    }
}
