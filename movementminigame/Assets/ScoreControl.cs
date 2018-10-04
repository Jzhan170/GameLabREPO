using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    int score = 0;

    public static ScoreControl control;

    public float count;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;

        }

    }

    private void Awake()
    {
        if(control == null)
        {
            DontDestroyOnLoad(gameObject);
        } else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    
}
