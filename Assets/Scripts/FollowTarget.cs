using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    private Vector3 targetPosition;

    private void FixedUpdate()
    {
        targetPosition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);
        transform.position = Vector3.Lerp(transform.position, targetPosition,Time.deltaTime);
    }
}
