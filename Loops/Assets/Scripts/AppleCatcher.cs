using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatcher : MonoBehaviour
{

    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("A");
        if (other.gameObject.tag.Equals("FallingApple"))
        {
            Debug.Log("A");
            Destroy(other.gameObject);
        }
    }
}
