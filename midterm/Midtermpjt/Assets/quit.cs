using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {

    public void Quit()
    {
        Debug.Log("quit game");
        Application.Quit(); 
    }

}
