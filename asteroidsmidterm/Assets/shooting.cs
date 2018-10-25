using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
    public GameObject shot;
    public float speed;
    void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shots = Instantiate(shot, transform.position, Quaternion.identity) as GameObject;
            shots.GetComponent<Rigidbody>().AddForce(transform.forward *speed * Time.deltaTime);
        }
    }
}
