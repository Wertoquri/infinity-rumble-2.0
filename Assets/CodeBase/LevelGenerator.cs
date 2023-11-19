using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
        
    public float minY = 1.3f;
    public float maxY = 3f;
    public float levelWidth = 3f;
    public GameObject platformPrefab;
    public int numberOfplatform = 50;
    public GameObject springPrefab;
        
    private Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfplatform; i++)
        {
            SpawnPlatform(platformPrefab);
        }
    }

    private void SpawnPlatform(GameObject prefab)
    {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            GameObject platform = Instantiate(prefab, spawnPosition, Quaternion.identity);
            int obstacleChance = Random.Range(1, 101);
            int springChance = Random.Range(1, 101);
            int trapChance = Random.Range(1, 101);

            if(obstacleChance <= 10)
            {
                platform.GetComponent<PlatformEffector2D>().enabled = false;
                platform.GetComponentsInChildren<SpriteRenderer>()[0].color = Color.yellow;
                platform.GetComponentsInChildren<SpriteRenderer>()[1].color = Color.yellow;
                platform.GetComponentsInChildren<SpriteRenderer>()[2].color = Color.yellow;
            }
            else if (trapChance <= 20)
            {
                platform.GetComponent<Platform>().isTrap = true;
                platform.GetComponentsInChildren<SpriteRenderer>()[0].color = Color.red;
                platform.GetComponentsInChildren<SpriteRenderer>()[1].color = Color.red;
                platform.GetComponentsInChildren<SpriteRenderer>()[2].color = Color.red;
            }
            if(springChance <= 15)
        {
            GameObject spring = Instantiate(springPrefab, transform.position, Quaternion.identity);
            Vector3 newPos = platform.transform.position;
            newPos.y += 0.4f;
            newPos.x += Random.Range(-0.2f, 0.2f);
            spring.transform.position = newPos;
        }

    }
    
    
}
