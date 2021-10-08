using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public float spawnRange = 20;
    public float spawnPosZ = -20;
    

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, spawnInterval);

    }

    void Update()
    {





    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
