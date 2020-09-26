using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {
    public GameObject enemy;
    public float spawnRate = 0.5f;

    float randY;
    float randX;
    Vector2 whereToSpawn;
    float nextSpawn = 0;

    void Start() {

    }

    void Update() {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            if (enemy.tag == "Grape")
            {
                randY = Random.Range(-23f, 14f);
                whereToSpawn = new Vector2(-22f, randY);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }
            else if(enemy.tag == "Apple")
            {
                randX = Random.Range(-17f, 23f);
                whereToSpawn = new Vector2(randX, 18.4f);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }
            else
            {
                randY = Random.Range(-23f, 14f);
                whereToSpawn = new Vector2(30f, randY);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }
        }
    }
}
