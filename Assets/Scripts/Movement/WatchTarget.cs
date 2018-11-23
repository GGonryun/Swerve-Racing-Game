using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchTarget : MonoBehaviour {

    [SerializeField] private Transform target;
    [SerializeField] private float rotationSpeed;
    private Quaternion ourRotation, targetRotation;
    private Vector3 displacement;

    private void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if(player)
        {
            target = player.transform;
        }
    }
    void Update()
    {
        if(target)
        {
            displacement = target.position - transform.position;
            targetRotation = Quaternion.LookRotation(Vector3.forward, displacement);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed / 100 * Time.deltaTime);
        }
    }

}
