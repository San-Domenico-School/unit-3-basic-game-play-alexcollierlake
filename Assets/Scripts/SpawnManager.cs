using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*********
 * component of the spawnManager, spawns animals 
 * into the scene but out of view.
 * 
 * Alexandra Collier-Lake
 * 10/03/2005
 **********/

public class SpawnManager : MonoBehaviour
{
    private float spawnRange; //distance from center to edge
    private float startDelay; //time between first spawn
    private float spawnInterval; //interval between spawns
    [SerializeField] private GameObject[] animals; //list of animals to spawn

    // calls spawnRandomAnimal() each interval after some delay
    void Start()
    {
        startDelay = 2.0f;
        spawnInterval = 3.0f;
        spawnRange = 13.0f;

        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // adds a random animal at a random point between the spawn ranges
    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animals.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 0.0f, 25.0f);
        GameObject animal = animals[animalIndex];

        Instantiate(animal, spawnPosition, animal.transform.rotation);
    }
}
