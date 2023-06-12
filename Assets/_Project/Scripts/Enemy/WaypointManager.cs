using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    // TODO: make the waypoint fields not wacky.
    [SerializeField] private static int waypointAmount = 5; // Number of waypoints; set with a default value to prevent a compilation error
    [SerializeField] private Vector3[] waypointTransforms = new Vector3[waypointAmount]; // Transform values for all of the waypoints

    public static WaypointManager managerInstance; // For singleton pattern; ensure only one waypoint manager exists in game

    private void Awake()
    {
        if (managerInstance == null)
        {
            managerInstance = this;
        } else
        {
            Debug.Log("Waypoint manager already exists!");
            Destroy(this.gameObject);
        }

        for (int i = 0; i < waypointTransforms.Length; i++)
        {
            Vector3 next = new Vector3(UnityEngine.Random.Range(-4, 4), UnityEngine.Random.Range(-4, 4), 0);
            waypointTransforms[i] = next;
        }
    }

    public Vector3[] GetWaypoints()
    {
        return waypointTransforms;
    }

    private void OnDrawGizmos()
    {
        Color pointColor = Color.white;
        Color wireColor = Color.red;

        Gizmos.color = pointColor;
        for (int i = 0; i < waypointAmount; i++)
        {
            Gizmos.DrawSphere(waypointTransforms[i], .25f);
        }
    }

    public static WaypointManager getInstance()
    {
        return managerInstance;
    }
}
