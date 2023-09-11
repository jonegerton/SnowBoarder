using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torqueAmount = 50f;

    [SerializeField] float boostSpeed = 30f;

    [SerializeField] float baseSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("PlayerController.Start");
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateMethod();
        ResponseToBoost();
    }

    void ResponseToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("PlayerController.ResponseToBoost: UpArrow");
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            Debug.Log("PlayerController.ResponseToBoost: DownArrow");
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotateMethod()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("PlayerController.RotateMethod: LeftArrow");
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("PlayerController.RotateMethod: RightArrow");
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
