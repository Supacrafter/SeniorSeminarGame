using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Spawn Pattern", menuName = "TDSO/SpawnPattern")]
public class SpawnPattern : ScriptableObject
{
    [Serializable]
    public struct SpawnPatternPoint
    {
        [SerializeField] private float spawnTime;
        [Tooltip("Only between 0 and # of diff enemies")]
        [SerializeField] private int enemyTypeIndex;

        public float GetSpawnTime() { return spawnTime; }

        public int GetEnemyTypeIndex() { return enemyTypeIndex; }
    }

    public SpawnPatternPoint[] spawnPattern;

    public SpawnPatternPoint[] GetSpawnPatternPoints() { return spawnPattern; }
}
