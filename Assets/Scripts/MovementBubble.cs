﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBubble : MonoBehaviour
{
    public float speed, strength;
    public SpawnObjects spawnBubbles;

    private void Start()
    {
        spawnBubbles = GameObject.Find("GenerateWater").GetComponent<SpawnObjects>();
        speed = Random.Range(speed - 0.3f, speed + 0.3f);
        if (speed < 0.2f)
            speed = 0.2f;
        strength = speed + 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 340)
        {
            transform.position = new Vector3(transform.position.x, Random.Range(spawnBubbles.offsetYMin, spawnBubbles.offsetYMax), transform.position.z);
        }

        transform.position += (Mathf.Sin(2 * Mathf.PI * speed * Time.time) - Mathf.Sin(2 * Mathf.PI * speed * (Time.time - Time.deltaTime))) * transform.right * strength;
        transform.position += new Vector3(0, speed / 2, 0);
    }
}
