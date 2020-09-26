using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tempPosition = transform.position;
        tempPosition.y -= 0.01f;

        transform.position = tempPosition;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "CatcherWall" || other.gameObject.tag == "PlayerTag")
        {
            Destroy(gameObject);
            Debug.Log(gameObject.tag);
        }
        
    }
}
