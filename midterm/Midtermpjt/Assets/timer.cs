using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {

	public int timeLeft = 3;
    public Text countdownText;
    public int sceneNum;
    void Start () {
        StartCoroutine("LoseTime");
	}
	
	
	void Update () {

        countdownText.text = ("MOVE IT: " + timeLeft);

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
