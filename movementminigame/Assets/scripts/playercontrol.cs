using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontrol : MonoBehaviour {
    public bool onGround;
    
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    public float playerSetX;
    public float playerSetY;
    public float playerSetZ;

    public float playerJumpHeight = 5;
    

     void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        onGround = true;
    
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce (movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (rb.position.y < -21.15f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    private void Update()
    {
        if (onGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector3(0f, 8f, 0f);
                onGround = false;
            }
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            onGround = true;
        }
    }
    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        if (count >= 1)
        {
            winText.text = "You Win!";
        }
    }
}
