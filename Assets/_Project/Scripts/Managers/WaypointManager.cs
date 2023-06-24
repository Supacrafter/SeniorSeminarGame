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
    [SerializeField] private bool randomWaypoints;
    [SerializeField] private GameObject waypointObject;
    [SerializeField] private GameObject pathObject;

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

        if (randomWaypoints)
        {
            GenerateRandomWaypoints();
        }

        DrawPaths();
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
        //for (int i = 0; i < waypointTransforms.Length; i++)
        //{
        //    Instantiate(waypointObject, waypointTransforms[i], Quaternion.identity);
        //}

        for (int i = 0; i < waypointTransforms.Length - 1; i++)
        {
            Vector3 origin = waypointTransforms[i];
            Vector3 next = waypointTransforms[i + 1];

            float distance = Vector2.Distance(origin, next);
            float angle = Vector2.Angle(next - origin, Vector2.right);

            if (next.y < origin.y)
            {
                angle = 360 - angle;
            }

            // Debug.Log("angle: " + angle + "; origin: " + origin + "; next: " + next);

            GameObject path = Instantiate(pathObject, waypointTransforms[i], Quaternion.Euler(0, 0, angle));
            SpriteRenderer sr = path.GetComponent<SpriteRenderer>();

            if (sr.drawMode == SpriteDrawMode.Tiled)
            {
                sr.size = new Vector2(distance, 1);
            }
        }
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