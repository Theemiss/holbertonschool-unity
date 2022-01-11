using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CameraController : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    public bool isInverted;
    public float turnSpeed = 5f;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.position;
        if (PlayerPrefs.GetInt("__inverted") == 0)
        {
            isInverted = true;
        }
    }
    void LateUpdate()
    {

        if (isInverted)
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;

            Vector3 desiredPosition = player.position + offset;
            //Vector3 SmoothPosition = Vector3.Lerp(transform.position, desiredPosition, 2f * Time.deltaTime);
            transform.position = desiredPosition;
            transform.LookAt(player.position);

            // Rotate the player
            player.Rotate(Input.GetAxis("Mouse X") * turnSpeed * Vector3.up);

        }
        else
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, -Vector3.up) * offset;

            Vector3 desiredPosition = player.position + offset;
            //Vector3 SmoothPosition = Vector3.Lerp(transform.position, desiredPosition, 2f * Time.deltaTime);
            transform.position = desiredPosition;
            transform.LookAt(player.position);

            // Rotate the player
            player.Rotate(Input.GetAxis("Mouse X") * turnSpeed * -Vector3.up);
        }


    }


}
