using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnDelay = 1f;
    [SerializeField] bool canSpawn = true;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }


    IEnumerator SpawnEnemies()
    {
        while(canSpawn)
        {
            Instantiate(enemyPrefab, transform);
            
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
