using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Apple")
        {
            Vector2 tempPosition = transform.position;
            tempPosition.y -= 0.01f;
            transform.position = tempPosition;
        }

        else if (this.tag == "Grape")
        {
            Vector2 tempPosition = transform.position;
            tempPosition.x += 0.01f;

            transform.position = tempPosition;
        }
        else if (this.tag == "Diamond")
        {
            Vector2 tempPosition = transform.position;
            tempPosition.x -= 0.01f;

            transform.position = tempPosition;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "AppleCatcherWall" && this.tag == "Apple") || (other.gameObject.tag == "GrapeCatcherWall" && this.tag == "Grape") || (other.gameObject.tag == "DiamondCatcherWall" && this.tag == "Diamond") || other.gameObject.tag == "PlayerTag")
        {
            Destroy(gameObject);
            Debug.Log(gameObject.tag);
            if (other.gameObject.tag == "PlayerTag")
            {
                Destroy(other.gameObject);
                SceneManager.LoadScene(0);
                
            }
        }
        
    }
}
