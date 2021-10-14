using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int spawnRangeX = 100;
    public int spawnRangeZ = 100;
    private float startDelay = 3;
    private float spawnInterval = 1.5f;




    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {


        


    }

    void SpawnRandomEnemy()
    {

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 3, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }

    
}
