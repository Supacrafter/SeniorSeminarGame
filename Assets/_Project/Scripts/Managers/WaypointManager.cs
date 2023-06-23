using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * WaypointManager
 * 
 * Manager class for all waypoints to create path for enemy
 * 
 * Currently handles path generation until I implement perlin noise map generation
 */

[DefaultExecutionOrder(-1)]
public class WaypointManager : MonoBehaviour
{
    [SerializeField] private Vector3[] waypointTransforms; // Transform values for all of the waypoints
    [SerializeField] private bool RandomWaypoints;

    public static WaypointManager Instance; // For singleton pattern; ensure only one waypoint manager exists in game

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Waypoint manager already exists!");
            Destroy(this);
        }

        if (RandomWaypoints)
        {
            GenerateRandomWaypoints();
        }
    }

    private void GenerateRandomWaypoints()
    {
        waypointTransforms[0] = new Vector3(-10.75f, UnityEngine.Random.Range(-4.75f, 4.75f), 0); // Enemy spawn point

        for (int i = 1; i < waypointTransforms.Length - 1; i++)
        {
            Vector3 next = new Vector3(UnityEngine.Random.Range(-6f, 6f), UnityEngine.Random.Range(-4f, 4f), 0);
            waypointTransforms[i] = next;
        }

        waypointTransforms[waypointTransforms.Length - 1] = new Vector3(10.75f, UnityEngine.Random.Range(-4.75f, 4.75f), 0); // Enemy end point
    }

    public Vector3[] GetWaypoints()
    {
        return waypointTransforms;
    }

    private void DrawPaths()
    {

    }

    private void OnDrawGizmos()
    {
        Color pointColor = Color.white;

        Gizmos.color = pointColor;
        for (int i = 0; i < waypointTransforms.Length; i++)
        {
            Gizmos.DrawSphere(waypointTransforms[i], .25f);
        }
    }
}
