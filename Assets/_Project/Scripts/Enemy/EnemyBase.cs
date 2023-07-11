using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

/*
 * Enemy Base
 * 
 * The base class for all other enemies to inherit from.
*/
public class EnemyBase : MonoBehaviour
{
    [SerializeField] private int remainingHealth; // Health this enemy currently has
    [SerializeField] private int maxHealth; // Maximum amount of health enemy can have
    [SerializeField] private float moveSpeed; // Speed at which enemy moves along path
    [SerializeField] private int moneyValue; // Money rewarded when enemy is killed

    private Vector3[] waypoints; // Reference to waypoints from WaypointManager
    private byte targetIndex; // index of current waypoint
    private Vector3 target; // target position to move towards
    private bool reachedEndOfPath;
    // private CircleCollider2D circleCollider;

    // Start is called before the first frame update
    void Start()
    {
        remainingHealth = maxHealth;

        waypoints = WaypointManager.Instance.GetWaypoints();

        transform.position = waypoints[0];

        targetIndex = 1;
        target = waypoints[targetIndex];
        // circleCollider = GetComponent<CircleCollider2D>();

        reachedEndOfPath = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target - transform.position;
        transform.position += direction.normalized * moveSpeed * Time.deltaTime;


        // TO-DO: Make this code less lazy. Checking the same thing twice (once in initial conditional, next in the try/catch block)
        if (targetIndex < waypoints.Length)
        {
            if (direction.sqrMagnitude < .001f) // direction.sqrMagnitude < circleCollider.radius * circleCollider.radius
            {
                try
                {
                    targetIndex++;
                    target = waypoints[targetIndex];
                } catch (IndexOutOfRangeException)
                {
                    Debug.Log("Done with path!");
                    reachedEndOfPath = true;
                    Destroy(gameObject);
                }
            }
        }
    }

    //private void TestPath() {
    //    int endPositionX = 9;

    //    if (transform.position.x < endPositionX)
    //    {
    //        transform.position = new Vector3(transform.position.x + (Time.deltaTime * moveSpeed), transform.position.y, transform.position.z);
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Projectile":
                remainingHealth -= collision.gameObject.GetComponent<ProjectileBase>().GetDamageValue();
                // Debug.Log("Hit! Health Left: " + remainingHealth);
                if (remainingHealth <= 0)
                {
                    Destroy(gameObject);
                }
                break;
            default:
                break;
        }
    }

    private void OnDestroy()
    {
        if (!reachedEndOfPath)
        {
            MoneyManager.instance.AddMoney(moneyValue);
            Debug.Log("Money rewarded: " + moneyValue);
        } else
        {
            Debug.Log("Miss!");
        }
        
    }
}
