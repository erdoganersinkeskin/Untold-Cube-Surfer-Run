using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnController : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private float spawnRate = 2f;
    [SerializeField] private float spawnDistanceRangeX = 3f;
    [SerializeField] private float spawnDistanceRangeZ = 3f;

    private float nextSpawnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnCube();
            nextSpawnTime = Time.time + spawnRate;
        }
    }
    void SpawnCube()
    {
        // Random x pozisyonu belirle
        float spawnX = Random.Range(-spawnDistanceRangeX, spawnDistanceRangeX);
        float spawnZ = Random.Range(spawnDistanceRangeZ, spawnDistanceRangeZ + 3);

        // Cube'u spawnla
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, transform.position.z + spawnZ);
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }
}
