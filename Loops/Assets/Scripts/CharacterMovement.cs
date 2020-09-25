using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 20f;
    Vector3 mMovement;

    Quaternion m_Rotation = Quaternion.identity;


    void Start()
    {

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        mMovement.Set(horizontal, vertical, 0f);
        mMovement.Normalize();

        transform.position += mMovement * Time.deltaTime * moveSpeed;

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, mMovement, turnSpeed * Time.deltaTime, 0f);
        m_Rotation = Quaternion.LookRotation(desiredForward);
    }

    void Update()
    {

    }
}
