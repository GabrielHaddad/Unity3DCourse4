using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocater : MonoBehaviour
{
    [SerializeField] Transform towerWeapon;
    Transform target;

    void Awake() 
    {
        target = FindObjectOfType<EnemyMover>().transform;
    }

    void Start()
    {

    }

    void Update()
    {
        AimWeapom();
    }

    void AimWeapom()
    {
        towerWeapon.LookAt(target);
    }
}
