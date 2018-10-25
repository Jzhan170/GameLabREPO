using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retrybutton : MonoBehaviour {

    public void ReStartGame(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
