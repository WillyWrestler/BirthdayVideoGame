using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask Groundmask;
    bool isGrounded;
    public float jumpHeight = 3f;
    bool firstJump;
    public float baseSpeed = 12f;
    

    private void Start()
    {
        
        firstJump = false;
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, Groundmask);
        
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            firstJump = true;
        }
        if (Input.GetButtonDown("Jump") && isGrounded == false && firstJump)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            firstJump = false;
        }
        if (Input.GetButtonDown("Run"))
        {
            speed = 18;
            
        }
        if (Input.GetButtonUp("Run"))
        {
            speed = baseSpeed;
        }
        velocity.y += gravity * Time.deltaTime;

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move* speed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);
    }
}
