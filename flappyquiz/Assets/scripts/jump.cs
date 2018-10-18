using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jump : MonoBehaviour {
    Rigidbody2D rb;
    public Text scoreText;
    private int score = 0;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        

    }
	
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0f, 5f, 0f); 
        }


	}

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.CompareTag("scorepoint"))
        {
            score = score + 1;

        }
    }
}
