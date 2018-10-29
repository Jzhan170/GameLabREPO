using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer2 : MonoBehaviour {

    public int timeLeft = 2;
    public Text countdownText;
    public int sceneNum;

    void Start () {
        StartCoroutine("LoseTime");
    }
	
	
	void Update () {
        countdownText.text = ("DRAG IT: " + timeLeft);

        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times Up!";
            SceneManager.LoadScene(sceneNum);
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }

    }
}
