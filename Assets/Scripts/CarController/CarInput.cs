using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInput : MonoBehaviour
{
    private CarController _controller;

    private void Awake()
    {
        _controller = GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        _controller.Throttle(Input.GetAxis("Vertical"));
        _controller.Steering(Input.GetAxis("Horizontal"));
    }
}
