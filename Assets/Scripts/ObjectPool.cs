using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] int poolSize = 5;
    [SerializeField] float spawnDelay = 1f;
    [SerializeField] bool canSpawn = true;

    GameObject[] pool;

    void Awake() 
    {
        PopulatePool();
    }

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for(int i = 0; i < pool.Length; i++)
        {
            pool[i] = Instantiate(enemyPrefab, transform);
            pool[i].SetActive(false);
        }
    }

    void EnableObjectInPool()
    {
        foreach(GameObject enemy in pool)
        {
            if (!enemy.activeInHierarchy)
            {
                enemy.SetActive(true);
                return;
            }
        }
    }

    IEnumerator SpawnEnemies()
    {
        while(canSpawn)
        {
            EnableObjectInPool();
            
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
