using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	
	void Update () {
        //transform.localPosition += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("killer"))
        {
            GameObject.Destroy(other.gameObject);
        }
    }
}
