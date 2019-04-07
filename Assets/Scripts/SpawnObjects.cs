using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn, holderObject;
    public float offsetXMin, offsetXMax, offsetYMin, offsetYMax, offsetZMin, offsetZMax;
    public int objectsToSpawn = 5, minSize = 1, maxSize = 2;

    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        for (int i = 0; i < objectsToSpawn; i++)
        {
            GameObject objectSpawned = Instantiate(objectToSpawn, new Vector3(Random.Range(offsetXMin, offsetXMax), Random.Range(offsetYMin, offsetYMax), Random.Range(offsetZMin, offsetZMax)), Quaternion.identity, holderObject.transform );
            float scale = Random.Range(minSize, maxSize);
            objectSpawned.transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
