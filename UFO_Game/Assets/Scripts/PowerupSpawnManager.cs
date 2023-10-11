using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PowerupSpawnManager : MonoBehaviour
{
    public GameObject[] powerupPrefabs; // Array to store power-ups
    private float spawnRangeX = 20f;
    private float spawnPositionZ = 20f;
    private float startDelay = 3f;
    private float spawnInterval = 5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomPowerup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ); //
        // int powerupIndex = Random.Range(0, powerupPrefabs.Length); // Picks a random power-up from the array
        Instantiate(powerupPrefabs[], spawnPos, powerupPrefabs[].transform.rotation); // Spawns indexed power-up from the array at a random location on the X-Axis
    }
}