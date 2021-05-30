using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabAnimals;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float spawnStart = 2;
    private float spawnDelay = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStart, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int animalIndex = Random.Range(0, prefabAnimals.Length);
        Instantiate(prefabAnimals[animalIndex], spawnPos, prefabAnimals[animalIndex].transform.rotation);
    }
}
