
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public playercontrol movement;


     void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Bottom")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }  
    }

}
