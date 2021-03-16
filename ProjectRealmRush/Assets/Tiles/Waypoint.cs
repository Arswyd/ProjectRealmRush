using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject towerPrefab;
    [SerializeField] bool isPlaceable;

    GameObject parentGameObject;

    private void Start()
    {
        parentGameObject = GameObject.FindWithTag("SpawnAtRuntime");
    }

    void OnMouseDown()
    {
        if(isPlaceable)
        {
            GameObject tower = Instantiate(towerPrefab, transform.position, Quaternion.identity);
            tower.transform.parent = parentGameObject.transform;
            isPlaceable = false;
        }
    }
}
