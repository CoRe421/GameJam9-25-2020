using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    float randY;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0;

    void Update() {
        if (Time.time > nextSpawn) {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-16f, -6f);
            randY = Random.Range(5f, -4.25f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
