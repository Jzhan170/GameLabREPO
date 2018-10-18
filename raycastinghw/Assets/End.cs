using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    public GameManager gameManager;
    public int sceneNum;

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(sceneNum);
    }
}
