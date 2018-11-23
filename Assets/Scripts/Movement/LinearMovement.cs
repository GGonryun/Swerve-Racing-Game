using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour {
    [SerializeField] private float linearSpeed;

    void FixedUpdate() {
        float translation = linearSpeed;
        translation *= Time.deltaTime;
        transform.Translate(0, translation, 0);
    }

}
