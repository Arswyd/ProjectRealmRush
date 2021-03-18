using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemiePrefab;
    [SerializeField] float spawnTimer = 1f;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (Time.time < 5f)
        {
            Instantiate(enemiePrefab, transform);
            yield return new WaitForSeconds(spawnTimer);
        }

    }
}
