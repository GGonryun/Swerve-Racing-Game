using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnAnimationTimeout : MonoBehaviour {

    [SerializeField] private float delay;
    private float animationDuration;

    private void Awake()
    {
        animationDuration = GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length;

    }

    private void Start()
    {
        Destroy(gameObject, animationDuration + delay);
    }
}
