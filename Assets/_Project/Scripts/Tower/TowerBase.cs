using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBase : MonoBehaviour
{
    #region InternalData
    // Might keep damage types, doesnt matter right now though
    private enum ShieldTypes
    {
        None,
        Heavy,
        Other
    };
    private int shieldType;
    private CircleCollider2D rangeCircle;
    private GameObject target;
    #endregion

    #region EditorData
    [SerializeField] private float towerRange;
    [SerializeField] private int damageValue;
    [SerializeField] private float attackSpeed;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rangeCircle = GetComponent<CircleCollider2D>();
        rangeCircle.radius = towerRange;
    }

    void FixedUpdate()
    {
        
    }

    public String GetShieldStatus()
    {
        switch (shieldType)
        {
            case 0:
                return "None";
            case 1:
                return "Heavy";
            case 2:
                return "Other";
            default:
                return null;
        }
    }

    private void ShootProjectile(GameObject target)
    {
        Debug.Log("Shooting at: " + target.transform.position);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision Enter!");
        target = collision.gameObject;
        ShootProjectile(target);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Collision Exit!");
        target = null;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, towerRange);
    }
}
