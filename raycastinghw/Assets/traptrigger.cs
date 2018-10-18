using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class traptrigger : MonoBehaviour {

    public Controller movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "trap")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
