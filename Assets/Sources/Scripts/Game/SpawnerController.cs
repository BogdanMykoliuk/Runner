using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public List<GameObject> obstacles;
    public GameObject[] additionalObstacles;

    private Transform thisTransform;
    private float currentDelay = 1;
    private float secondsPerSpawn = 3;

    private bool canAdd = true;

    private void Awake()
    {
        thisTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Progress.playerScore >= 150 && canAdd)
        {
            canAdd = false;
            obstacles.AddRange(additionalObstacles);
        }
        if (currentDelay >= secondsPerSpawn) 
        {
            SpawnObstacle();
            currentDelay = Random.Range(-0.5f, 0.3f);
        }
        if (secondsPerSpawn >= 1f) 
        {
            secondsPerSpawn -= 0.1f * Time.deltaTime;
        }
        //Debug.LogWarning(secondsPerSpawn);
        currentDelay += Time.deltaTime;
    }

    public void SpawnObstacle() 
    {
        GameObject obstacleToSpawn = obstacles[Random.Range(0, obstacles.Count)];
        Instantiate(obstacleToSpawn,thisTransform);
    }
}
