using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScriptY : MonoBehaviour
{
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
            randX = Random.Range(player.transform.position.x-10, player.transform.position.x + 10);
            //randY = Random.Range(player.transform.position.y + 8, player.transform.position.y + 12);
            whereToSpawn = new Vector2(randX, 18.4f);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
