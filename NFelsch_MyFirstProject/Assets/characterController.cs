using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        moveDirection = new
            Vector3(horizontalInput, verticalInput, 0f);
       
        // Calculating moveDirection with input values
        moveDirection *= moveSpeed;
       
        if(Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            var b = isJumping == true;
        }
       
        // Apply gravity to moveDirection
        moveDirection.y -= gravity * Time.deltaTime;
       
        // Move the character controller
        controller.Move(moveDirection * Time.deltaTime);
        
        if (isJumping == true)
        {
            moveDirection.y = jumpForce;
            var b = isJumping == false;
        }

    }

}