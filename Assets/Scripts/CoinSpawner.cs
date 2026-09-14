using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class CoinSpawner : MonoBehaviour
{
    [Header("Coin Settings")]
    public GameObject coinPrefab;
    
    [Header("Spawn Timer")]
    public float minSpawnTime = 5f;
    public float maxSpawnTime = 10f;

    [Header("Spawn Points")]// Organize script fields in inspector
    public Transform[] spawnPoints;

    void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    IEnumerator SpawnCoins()
    {
        while (true)
        {
            // Wait a random amount of time between 2 set times
            float waitTime = Random.Range(minSpawnTime, maxSpawnTime);

            yield return new WaitForSeconds(waitTime);

            SpawnCoin();
        }
    }

    void SpawnCoin()
    {
       

        // Pick a random spawn point
        int randomIndex = Random.Range(0, spawnPoints.Length);

        Transform spawnPoint = spawnPoints[randomIndex];

        // Spawn the coin
        Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity);
    }
}

