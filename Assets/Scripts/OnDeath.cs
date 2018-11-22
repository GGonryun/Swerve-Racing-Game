using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeath : MonoBehaviour {
    [SerializeField] private GameObject deathAnimation;

    private void OnDisable()
    {
        Instantiate(Resources.Load("Prefabs/Explosion"),gameObject.transform.position,gameObject.transform.rotation);
    }
}
