using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
public class DestroyOnContact : MonoBehaviour {
    [SerializeField] private BoxCollider2D bc;
    [SerializeField] private string[] enemies;
    private void Awake() {
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        for(int i = 0; i < enemies.Length; i++) {
            if(collision.tag == enemies[i]) {
                Destroy(gameObject);
            }
        }
    }
}
