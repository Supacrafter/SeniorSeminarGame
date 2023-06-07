using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    [SerializeField] private float projectileSpeed; // Speed at which projectile moves
    [SerializeField] private int projectileDamage; // Damage projectile deals
    [SerializeField] private Transform target; // Target projectile is following
    private Rigidbody2D rb; // Rigidbody of projectile
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.position += direction.normalized * projectileSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Enemy":
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    public int GetDamageValue()
    {
        return projectileDamage;
    }
}
