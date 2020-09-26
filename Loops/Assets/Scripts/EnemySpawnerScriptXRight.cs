﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScriptXRight : MonoBehaviour {
    public GameObject enemy;
    public GameObject player;

    float randY;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 0.5f;
    float nextSpawn = 0;

    void Start() {

    }

    void Update() {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(player.transform.position.y - 5, player.transform.position.y + 8);
            whereToSpawn = new Vector2(30f, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
