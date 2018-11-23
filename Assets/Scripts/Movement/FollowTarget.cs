using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float speed;
    private Vector3 targetPosition;

    private void FixedUpdate()
    {
        if(target)
        {
            targetPosition = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}
