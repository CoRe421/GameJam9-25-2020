using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    public Player player;

    float randY;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 0.5f;
    float nextSpawn = 0;

    void Start() {
        player = FindObjectOfType<Player>();
    }

    void Update() {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(player.transform.position.x, player.transform.position.x + 10);
            randY = Random.Range(player.transform.position.y + 8, player.transform.position.y + 12);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
