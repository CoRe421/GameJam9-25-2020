using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    Collider2D collider;
    public Player player;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        collider = GetComponent<Collider2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other == player.GetComponent<Collider2D>()) {
            score += 1;
            Debug.Log(score);
        }
    }
}
