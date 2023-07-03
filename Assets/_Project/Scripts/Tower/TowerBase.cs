using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.UI.Image;
/*
 * Tower base
 * 
 * Base class for all other towers to inherit from
 */
public class TowerBase : MonoBehaviour
{
    [SerializeField] private float towerRange; // Range of tower
    [SerializeField] private float attackSpeed; // Speed tower is able to attack enemies (in seconds)
    [SerializeField] private GameObject projectile; // Projectile to shoot
    [SerializeField] private bool canShoot; // For debug purposes
    [SerializeField] private int cost;
    [SerializeField] private LayerMask layerMask;

    private CircleCollider2D rangeCircle; // Circle collider representing vision of tower
    private GameObject currentTarget; // Target tower is shooting at
    private Queue<GameObject> targets;
    private float lastShot;


    // TODO: Make the target into a list of gameObjects, acting as a queue for next enemy to shoot at
    // TODO: Make all projectiles per tower into an object pool, optimization
    // Start is called before the first frame update
    void Start()
    {
        rangeCircle = GetComponent<CircleCollider2D>();
        rangeCircle.radius = towerRange;
        targets = new Queue<GameObject>();
    }

    private void FixedUpdate()
    {
        if (currentTarget != null)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, currentTarget.transform.position - transform.position, Mathf.Infinity, layerMask);
            Debug.DrawRay(transform.position, currentTarget.transform.position - transform.position, Color.red);

            if (hit.collider != null && hit.collider.gameObject.CompareTag("Enemy") && Time.time > lastShot + (1f / attackSpeed) && canShoot)
            {
                ShootProjectile(currentTarget.transform);
                lastShot = Time.time;
            }
        }
    }

    private void ShootProjectile(Transform target)
    {
        Debug.Log("Shooting at: " + target);
        GameObject projectileInstance = Instantiate(projectile);
        projectileInstance.transform.position = transform.position;
        projectileInstance.GetComponent<ProjectileBase>().SetTarget(target);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag) {
            case "Enemy":
                
                // Debug.Log("Collision Enter!");

                if (currentTarget == null)
                {
                    currentTarget = collision.gameObject;
                    targets.Enqueue(currentTarget);
                } else
                {
                    targets.Enqueue(collision.gameObject);
                }
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Enemy":
                targets.Dequeue();
                if (targets.Count > 0)
                {
                    currentTarget = targets.Peek();
                } else
                {
                    currentTarget = null;
                }
                break;
            default:
                break;
        }
    }

    public int GetCost()
    {
        return cost;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, towerRange);
    }
}
