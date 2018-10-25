using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obsticle : MonoBehaviour {

    public Text scoreText;
    private int score = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("scorepoint"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            
        }
    }
}
