using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private InputManager inputManager;
    
    private Vector3 inputVector;
    private Vector3 movementVector;
    private Vector3 targetRotation;

    
    //Mustafa Eyüp Karataş
    
    void Start()
    {
        
    }
    
    void Update()
    {
        if (inputManager.InputVector != Vector3.zero)
        {
            movementVector = inputVector;
        }
        else
        {
            movementVector = Vector3.zero;
        }
    }

    private void FixedUpdate()
    {
        rigidbody.transform.position += movementVector * Time.fixedDeltaTime;
    }
}
