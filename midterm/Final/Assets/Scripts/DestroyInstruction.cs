﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInstruction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKey)
        {
            Destroy(this.gameObject);
        }
    }
}
