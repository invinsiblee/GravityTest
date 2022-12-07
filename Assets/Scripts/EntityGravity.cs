using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGravity : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private GravityFlip Flip;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0,Flip.currentGravity, 0);
    }
}
