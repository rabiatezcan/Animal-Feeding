using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float spawnRangeX = 16;
    float spawnPosZ = 20;
    float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreateAnimal();  
    }

    public void CreateAnimal()
    {
        float time = Random.Range(.2f, 4f);
        while(currentTime >= time)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

            currentTime = 0;
        }
        currentTime += Time.deltaTime;
    }
}
