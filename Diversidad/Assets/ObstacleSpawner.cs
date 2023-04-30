using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public float spawnInterval = 2f;
    public GameObject[] obstacleSets;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    private IEnumerator SpawnObstacles()
    {
        while (true)
        {
            // Randomly select an obstacle set
            int index = Random.Range(0, obstacleSets.Length);
            GameObject obstacleSet = obstacleSets[index];

            // Spawn the obstacle set at the spawn point
            Instantiate(obstacleSet, spawnPoint.position, Quaternion.identity);

            // Wait for the specified interval before spawning the next set
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
