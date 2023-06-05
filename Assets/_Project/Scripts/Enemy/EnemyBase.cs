using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    [SerializeField] private int remainingHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        remainingHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        TestPath();
    }

    private void TestPath() {
        int endPositionX = 9;

        if (transform.position.x < endPositionX)
        {
            transform.position = new Vector3(transform.position.x + (Time.deltaTime * moveSpeed), transform.position.y, transform.position.z);
        }
    }
}
