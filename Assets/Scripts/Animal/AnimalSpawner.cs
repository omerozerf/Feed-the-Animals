using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimalSpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] animals;
    [SerializeField] private float xRange;
    [SerializeField] private float yPos;
    [SerializeField] private float zPos;
    [SerializeField] private float spawnRate;
    [SerializeField] private float minSpawnRate;
    [SerializeField] private float counterDivision;
    
    
    
    private void Start()
    {
        StartCoroutine(SpawnAnimals());
    }
    
    private IEnumerator SpawnAnimals()
    {
        int counter = 0;
        while (true)
        {
            counter++;

            if (counter % counterDivision == 0 && spawnRate > minSpawnRate)
            {
                spawnRate = spawnRate - (spawnRate / 5);
            }
            
            int randomNumber = Random.Range(0, animals.Length);
            Instantiate(animals[randomNumber], RandownSpawnPosition(), animals[randomNumber].transform.rotation);

            yield return new WaitForSeconds(spawnRate);
        }
        
    }

    private Vector3 RandownSpawnPosition()
    {
        float randomXValue = Random.Range(-xRange, xRange);
        return new Vector3(randomXValue, yPos, zPos);
    }

    
}
