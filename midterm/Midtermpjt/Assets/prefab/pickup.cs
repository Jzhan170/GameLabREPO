using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pickup : MonoBehaviour {

    public movement movement;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "pickup")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().CompleteLevel();

        }
    }
}
