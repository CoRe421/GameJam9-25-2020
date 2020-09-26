using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 20f;
    Vector3 mMovement;


    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        mMovement.Set(horizontal, vertical, 0f);

        transform.position += mMovement * Time.deltaTime * moveSpeed;

        /**
        float rotation = -horizontal * turnSpeed;
        transform.Rotate(transform.forward * rotation);
        **/

        float rotation = -horizontal * turnSpeed;
        transform.Rotate(Vector3.forward * rotation);

    }


    void OnTriggerEnter2D()
    {

    }


    void Update()
    {

    }
}
