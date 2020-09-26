using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public float moveSpeed = 3f;
    public Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.tag == "Apple")
        {
            velocity.y = -moveSpeed;
            transform.Translate(velocity * Time.deltaTime);
        }

        else if (this.tag == "Grape")
        {
            velocity.x = moveSpeed;
            transform.Translate(velocity * Time.deltaTime);
        }
        else if (this.tag == "Diamond")
        {
            velocity.x = -moveSpeed;
            transform.Translate(velocity * Time.deltaTime);
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
