using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    [Header("Debug")]
    [SerializeField] private GameObject testEnemyPrefab;
    [SerializeField] private GameObject spawnEnemyButton;
    [SerializeField] private int currentWaveNum;
    [SerializeField] private int currentEnemyInWave;
    [SerializeField] private float lastSpawn;

    [Header("Attributes")]
    [SerializeField] private GameObject[] enemyTypes;
    [SerializeField] private SpawnPattern[] waves;

    private bool waveDone;

    private void Start()
    {
        spawnEnemyButton.GetComponent<Button>().onClick.AddListener(SpawnEnemy);
        waveDone = false;
    }

    private void FixedUpdate()
    {
        if (currentEnemyInWave < waves[currentWaveNum].spawnPattern.Length && !waveDone)
        {
            if (lastSpawn + waves[currentWaveNum].spawnPattern[currentEnemyInWave].GetSpawnTime() < Time.time)
            {
                SpawnNextEnemy();
                lastSpawn = Time.time;
                currentEnemyInWave++;
            }
        }
        else
        {
            if (!waveDone)
            {
                Debug.Log("Done spawning!");
                waveDone = true;
            }
        }

    }

    private void SpawnEnemy()
    {
        Vector3 spawnPos = WaypointManager.Instance.GetWaypoints()[0];
        GameObject enemy = Instantiate(testEnemyPrefab);
        enemy.transform.position = spawnPos;
    }

    private void SpawnNextEnemy()
    {
        Vector3 spawnPos = WaypointManager.Instance.GetWaypoints()[0];
        SpawnPattern currentWave = waves[currentWaveNum];
        // currentWave.spawnPattern[currentEnemyInWave];
        int enemyIndex = currentWave.spawnPattern[currentEnemyInWave].GetEnemyTypeIndex();

        GameObject enemy = Instantiate(enemyTypes[enemyIndex]);
        enemy.transform.position = spawnPos;
    }
}
