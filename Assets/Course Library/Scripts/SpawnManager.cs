using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRange;
    private float startDelay;
    private float spawnInterval;
    [SerializeField] private GameObject[] animals;

    // Start is called before the first frame update
    void Start()
    {
        startDelay = 2.0f;
        spawnInterval = 1.5f;
    }

    private void SpawnRandomAnimal()
    {
        //to be implemented
    }
}
