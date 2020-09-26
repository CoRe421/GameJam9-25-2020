using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        transform.position = Player.transform.position + offset;
    }
}
