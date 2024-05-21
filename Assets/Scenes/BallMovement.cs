using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    public InputHandler inputHandler;
    public GameController gameController;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        if (inputHandler.IsTouch())
        {
            _rigidbody.AddForce(speed*inputHandler.GetTouchDeltaPosition().normalized);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            gameController.OnLevelComplete();
        }
    }
}
