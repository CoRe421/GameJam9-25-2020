using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyXRight : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Vector2 tempPosition = transform.position;
        tempPosition.x -= 0.01f;

        transform.position = tempPosition;
    }
}
