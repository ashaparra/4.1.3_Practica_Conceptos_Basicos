/* Created by: Fernanda Cortés & Arantza Parra 
03/09/23
Script created for enemies to be created at random and move from 2 different
positions 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Create values for the enemy to appair and for the next to come
    public float spawnDelay = .3f;
    public GameObject enemy;
    float nextSpawn = 0f;

    // Create a array with the positions from where the enemy will come out
    public Transform[] EnemyPositions;

// Function to determine the time between one and the next enemy
    void Update(){
        if(nextSpawn <= Time.time)
        {
            SpawnEnemy();
            nextSpawn = Time.time + spawnDelay;

        }
    }

    void SpawnEnemy(){

        // Get a random number to select a point from the Enemy Array
        int randomIndex= Random.Range(0, EnemyPositions.Length);
        Transform EnemyPosition = EnemyPositions[randomIndex];

        Instantiate(enemy, EnemyPosition.position, EnemyPosition.rotation);
    }
}
