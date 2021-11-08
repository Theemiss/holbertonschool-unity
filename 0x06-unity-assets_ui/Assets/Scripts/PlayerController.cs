using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController charCon;
    public float speed = 6f;
    private float gravity = -9.8f * 2;
    private Vector3 gravityVector = Vector3.zero;
    public float maxJumpHeight = 3f;
    private bool isGrounded = true;
    void FixedUpdate()
    {
        isGrounded = charCon.isGrounded;
        // Move horizontally and forward backward
        float xaxis = Input.GetAxis("Horizontal");
        float zaxis = Input.GetAxis("Vertical");
        Vector3 direction = transform.right * xaxis + transform.forward * zaxis;

        charCon.Move(direction * speed * Time.deltaTime);

        // Handle Jump
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            gravityVector.y = Mathf.Sqrt(maxJumpHeight * -3.0f * gravity);
        }
        // Handle gravtity
        gravityVector.y += gravity * Time.deltaTime;
        charCon.Move(gravityVector * Time.deltaTime);
        if (charCon.isGrounded == true && gravityVector.y < 0)
        {
            gravityVector.y = -1f;
        }

        // Repeat in case of falling
        if (transform.position.y < -20)
        {
            transform.position = new Vector3(0, 20, 0);
        }
    }
}