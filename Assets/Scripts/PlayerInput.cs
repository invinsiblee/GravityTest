using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public bool flipGravity;
    public bool gravityBomb;
    
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        flipGravity = Input.GetKeyDown(KeyCode.Space);
        gravityBomb = Input.GetKeyDown(KeyCode.E);
    }
}
