using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource), typeof(Rigidbody2D))]
public class PlayOnContact : MonoBehaviour {

    [SerializeField] private AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audio.Play();
    }

}
