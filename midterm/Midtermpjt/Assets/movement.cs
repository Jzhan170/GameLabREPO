using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, 3f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector2(0f, -3f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-3f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(3f, 0f);
        }

    }


    //void OnTriggerEnter(Collider2D other)
    //{
        //if (other.gameObject.CompareTag("pickup"))
       // {
            //other.gameObject.SetActive(false);


        //}
    //}
}

