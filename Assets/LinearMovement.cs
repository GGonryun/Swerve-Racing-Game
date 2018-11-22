using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class LinearMovement : MonoBehaviour {
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start () {
        rb.velocity = new Vector2(0f, speed);
    }

}
