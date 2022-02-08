using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHP = 5;
    int currentHP = 0;

    void Start()
    {
        currentHP = maxHP;
    }

    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        TakeDamage();
    }

    void TakeDamage()
    {
        currentHP--;

        if (currentHP <= 0)
        {
            KillEnemy();
        }
    }

    void KillEnemy()
    {
        Destroy(gameObject);
    }
}
