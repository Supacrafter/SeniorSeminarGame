using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
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
    [SerializeField] private Vector2[] waypoints; // Transform values for all of the waypoints
    [SerializeField] private GameObject waypointObject;
    [SerializeField] private GameObject pathObject;
    [SerializeField] private bool RandomWaypoints; // For editor toggle, if random waypoints are to be generated

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
        
        for (int i = 0; i < waypoints.Length; i++)
        {
            Instantiate(waypointObject, new Vector3 (waypoints[i].x, waypoints[i].y, 0), Quaternion.identity);
        }

        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            GameObject path = Instantiate(pathObject, waypoints[i], Quaternion.identity);
            SpriteRenderer spriteRenderer = path.GetComponent<SpriteRenderer>();
            
            if (spriteRenderer.drawMode == SpriteDrawMode.Tiled)
            {
                try
                {
                    spriteRenderer.size = new Vector2(Vector2.Distance(waypoints[i], waypoints[i + 1]), 1);
                    // TODO: Make path tiles rotate towards next waypoint
                    // path.transform.rotation = Quaternion.Euler(0, 0, Vector3.Angle)
                } catch (IndexOutOfRangeException)
                {
                    // Do nothing
                }

                //spriteRenderer.size;    
            }
        }
    }

    private void GenerateRandomWaypoints()
    {
        waypoints[0] = new Vector2(-10.75f, UnityEngine.Random.Range(-4.75f, 4.75f)); // Enemy spawn point

        for (int i = 1; i < waypoints.Length - 1; i++)
        {
            Vector3 next = new Vector2(UnityEngine.Random.Range(-6f, 6f), UnityEngine.Random.Range(-4f, 4f));
            waypoints[i] = next;
        }

        waypoints[waypoints.Length - 1] = new Vector2(10.75f, UnityEngine.Random.Range(-4.75f, 4.75f)); // Enemy end point
    }

    public Vector2[] GetWaypoints()
    {
        return waypoints;
    }

    private void OnDrawGizmos()
    {
        Color pointColor = Color.red;

        Gizmos.color = pointColor;
        for (int i = 0; i < waypoints.Length; i++)
        {
            Gizmos.DrawSphere(waypoints[i], .25f);
        }
    }
}
