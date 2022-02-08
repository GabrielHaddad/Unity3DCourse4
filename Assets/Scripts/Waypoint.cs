using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaceble;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnMouseDown() 
    {
        if (isPlaceble)
        {
            PlaceTowers();
        }
    }

    void PlaceTowers()
    {
        Instantiate(towerPrefab, transform.position, Quaternion.identity);
        isPlaceble = false;
    }
}
