using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcher : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "FallingApple")
        {
            Destroy(other.gameObject);
        }
    }
}
