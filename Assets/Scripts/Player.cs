using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundCheck;
    
    public float speed = 3f;
    public float gravity = -9.81f;
    public float groundDistace = 0.4f;
    public float jumpHeight = 1f;

    public LayerMask groundMask;
   
    Vector3 velocity;

    bool isGrounded;
   
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistace, groundMask);
        
        if (isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }  

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime); 

        if (Input.GetButtonDown("Jump") && isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
