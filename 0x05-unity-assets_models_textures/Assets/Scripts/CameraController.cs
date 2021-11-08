using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    public float turnSpeed = 5f;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.position;
    }   
    void LateUpdate()
    {


        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;

        Vector3 desiredPosition = player.position + offset;
        //Vector3 SmoothPosition = Vector3.Lerp(transform.position, desiredPosition, 2f * Time.deltaTime);
        transform.position = desiredPosition;
        transform.LookAt(player.position);

        // Rotate the player
        player.Rotate(Input.GetAxis("Mouse X") * turnSpeed * Vector3.up);


    }


}
