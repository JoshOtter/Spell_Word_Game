using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBombSpawn : MonoBehaviour
{
    public GameObject towerBombPrefab;
    public float startTime = 2f;
    public float repeatTime = 3f;

    void Start()
    {
        InvokeRepeating("Spawn", startTime, repeatTime);
    }

    void Spawn()
    {
        Instantiate(towerBombPrefab, transform.position, Quaternion.identity);
    }
}
