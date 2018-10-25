using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;
    private int score = 0;

    public void Scored()
    {
        score = score + 1;
        scoreText.text = "score:" + score.ToString();
    }

    
}
