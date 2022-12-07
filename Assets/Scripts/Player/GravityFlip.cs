using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    private PlayerInput _input;
    [SerializeField] 
    private float downGravity = -9.81f;
    [SerializeField] 
    private float upGravity = 9.81f;
    public float currentGravity;

    public bool normGravity;
    
    void Start()
    {
        _input = GetComponent<PlayerInput>();
        normGravity = true;
        currentGravity = downGravity;
    }

    void Update()
    {
        if (_input.flipGravity)
        {
            normGravity = !normGravity;
        }
        currentGravity = normGravity ? downGravity : upGravity;
    }
}
