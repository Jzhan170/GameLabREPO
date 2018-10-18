using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int sceneNum;
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completelevelUI;

    public void CompleteLevel()
    {
        SceneManager.LoadScene(sceneNum);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
