using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float carSpeed = 20;
    [SerializeField] private float steerFactor = 10;
    [SerializeField] private float steerAmount = 8;
    private Rigidbody2D _rigidbody2D;
    private float _steering;
    private float _throttle;
    //Outputs
    // -> add forces to rigidbody
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    //0 no throttle, 1 is all the way down, -1 is brake
    public void Throttle(float throttle)
    {
        _throttle = Mathf.Clamp(throttle,-1,1);
    }
    //-1 left, 0 straight, 1 right
    public void Steering(float steering)
    {
        _steering = Mathf.Clamp(steering, -1, 1);
    }

    public void FixedUpdate()
    {
        //Apply forward force
        //Get the local up (y) direction.
        _rigidbody2D.AddForce(transform.up*_throttle* carSpeed);

        //apply steering force
        //multiply by some velocity factor
        float vel = _rigidbody2D.velocity.magnitude;
        float velocityFactor = Mathf.Clamp(vel/steerAmount,0,1);
        _rigidbody2D.AddTorque(-_steering*steerFactor*velocityFactor);

        //apply a friction/drag force(s)
        //percentage of our velocity that is local forward
        //percentage of our velocity that is local right
        //Dot products
        float sidewaysFactor = Vector2.Dot(_rigidbody2D.velocity.normalized, transform.right);
        _rigidbody2D.AddForce(-transform.right * (vel * sidewaysFactor));
    }
}
