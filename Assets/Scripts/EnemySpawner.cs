using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemyPrefab;
    public float spawnInterval = 2f; 

    private Camera mainCamera;
    private float spawnDistance = 10f;

    void Start()
    {
        mainCamera = Camera.main;
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        if (!playerHealth.isDead)
        {
            Vector2 spawnPosition = GetRandomSpawnPosition();
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }

        Vector2 GetRandomSpawnPosition()
    {
        Vector2 cameraPosition = mainCamera.transform.position;
        float cameraHeight = 2f * mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        Vector2 spawnPosition = Vector2.zero;

        int zone = Random.Range(0, 4);

        switch (zone)
        {
            case 0: // Above
                spawnPosition = new Vector2(
                    Random.Range(cameraPosition.x - cameraWidth / 2, cameraPosition.x + cameraWidth / 2),
                    cameraPosition.y + cameraHeight / 2 + spawnDistance
                );
                break;
            case 1: // Below
                spawnPosition = new Vector2(
                    Random.Range(cameraPosition.x - cameraWidth / 2, cameraPosition.x + cameraWidth / 2),
                    cameraPosition.y - cameraHeight / 2 - spawnDistance
                );
                break;
            case 2: // Left
                spawnPosition = new Vector2(
                    cameraPosition.x - cameraWidth / 2 - spawnDistance,
                    Random.Range(cameraPosition.y - cameraHeight / 2, cameraPosition.y + cameraHeight / 2)
                );
                break;
            case 3: // Right
                spawnPosition = new Vector2(
                    cameraPosition.x + cameraWidth / 2 + spawnDistance,
                    Random.Range(cameraPosition.y - cameraHeight / 2, cameraPosition.y + cameraHeight / 2)
                );
                break;
        }

        return spawnPosition;
    }
}

