using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public List<GameObject> obstacles;
    public GameObject[] additionalObstacles;

    public List<GameObject> coins;
    private float coinsTimeDelay = 5;
    private float currentCoinsTimeDelay = 0;

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
        if (currentCoinsTimeDelay >= coinsTimeDelay && currentDelay >= 0.3f && currentDelay <= 0.9f)
        {
            SpawnCoin();
            currentCoinsTimeDelay = currentCoinsTimeDelay - coinsTimeDelay;
        }
        if (Progress.playerScore >= 150 && canAdd)
        {
            canAdd = false;
            obstacles.AddRange(additionalObstacles);
        }
        if (currentDelay >= secondsPerSpawn)
        {
            SpawnObstacle();
            currentDelay = Random.Range(-0.35f, 0);
        }
        if (secondsPerSpawn >= 1f)
        {
            secondsPerSpawn -= 0.1f * Time.deltaTime;
        }
        currentDelay += Time.deltaTime;
        currentCoinsTimeDelay += Time.deltaTime;
    }

    public void SpawnObstacle() 
    {
        GameObject obstacleToSpawn = obstacles[Random.Range(0, obstacles.Count)];
        Instantiate(obstacleToSpawn,thisTransform);
    }

    public void SpawnCoin()
    {
        GameObject coinToSpawn = coins[Random.Range(0, coins.Count)];
        Instantiate(coinToSpawn, thisTransform);
    }
}
