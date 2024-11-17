using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceDrop : MonoBehaviour
{
    public GameObject expPrefab;
    public Transform spawnPoint;

    public void SpawnExp() 
    {
        GameObject exp = Instantiate(expPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
