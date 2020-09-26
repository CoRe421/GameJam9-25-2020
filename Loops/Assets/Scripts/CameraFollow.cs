using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Player;
    Vector3 offset;

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        if (Player != null)
        {
            transform.position = Player.transform.position + offset;
        }
        
    }
}
