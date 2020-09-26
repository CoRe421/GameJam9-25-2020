using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    Collider2D collider;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.tag == "PlayerTag")
        {
            score += 1;
            Debug.Log(score);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }


}
