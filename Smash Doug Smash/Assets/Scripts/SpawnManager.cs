using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float rangeX = 20;
    private float posZ = 20;
    private float startDelay = 1.5f;
    public float spawnInterval = .000001f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex   = Random.Range(0, animalPrefabs.Length);
        GameObject animal = animalPrefabs[animalIndex];
        float posX        = Random.Range(-rangeX, rangeX);
        Vector3 spawnPos  = new Vector3(posX, 0, posZ);

        Instantiate(animal, spawnPos, animal.transform.rotation);
    }
}
