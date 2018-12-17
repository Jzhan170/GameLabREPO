﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour {

    Rigidbody rb;
    public float moveForce;
    public float turnForce;
	void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	
	void Update () {
		
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.forward*moveForce, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(Vector3.up * turnForce,ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(Vector3.down * turnForce, ForceMode.Impulse);
        }
        ScreenWarp();

    }

    void ScreenWarp()
    {
        if(transform.position.x< -34)
        {
            transform.position = new Vector3(33, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 34)
        {
            transform.position = new Vector3(-33, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -26)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 25);
        }
        if (transform.position.z > 26)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -25);
        }
    }
}
