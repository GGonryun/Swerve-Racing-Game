using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D), typeof(Rigidbody2D))]
public class DestroyOnContact : MonoBehaviour {
    [SerializeField] private string[] enemies;

    private void OnTriggerEnter2D(Collider2D collision) {

        for(int i = 0; i < enemies.Length; i++) {
            if(collision.tag == enemies[i]) {
                GameManager.instance.score++;
                Instantiate(Resources.Load("Prefabs/Objects/Explosion"), gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
