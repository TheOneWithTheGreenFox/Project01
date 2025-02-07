using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnTimer;
    public float spawnTime;

    public GameObject enemy;

    void Update()
    {
        if (spawnTime < spawnTimer)
        {
            spawnTime += Time.deltaTime;
        }
        else
        {
            spawnTime = 0;

            Instantiate(enemy, transform.position, Quaternion.identity, null);
        }
    }
}
