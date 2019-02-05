﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{

    public GameObject ball;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 10f;
    float nextSpawn = 0.0f;

    void Update()
    {
        if (Time.time > nextSpawn)
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8f, 8f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(ball, whereToSpawn, Quaternion.identity);
        }

    }

