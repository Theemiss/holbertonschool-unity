using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
    public float smoothFactor = 0.5f;
    public Transform player;
    public Vector3 offset;
    public bool lookAtTarget = false;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        Vector3 newPosition = player.transform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);
        if (lookAtTarget)
        {
            transform.LookAt(player);
        }
    }


}
