using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput _input;
    private Rigidbody rb;
    private GravityFlip flip;
    
    [SerializeField] 
    private float moveSpeed = 4f;
    
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
        flip = GetComponent<GravityFlip>();
    }
    
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        rb.velocity = new Vector2(_input.horizontalInput * moveSpeed, flip.currentGravity);
    }
}
