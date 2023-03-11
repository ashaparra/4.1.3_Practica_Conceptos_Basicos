using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnDelay = .3f;
    public GameObject enemy;

    float nextSpawn = 0f;

    void Update(){
        if(nextSpawn >= Time.time){
            SpawnEnemy();
            nextSpawn = Time.time + spawnDelay;

        }
    }

    void SpawnEnemy(){
        Instantiate(enemy);
    }
}
