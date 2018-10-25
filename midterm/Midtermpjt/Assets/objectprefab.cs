using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectprefab : MonoBehaviour {
    public GameObject Cubeprefab;
    //public GameObject Targetprefab;
    public static Vector2 targetpos;
    


    void Start()
    {
        targetpos = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));

        Instantiate(Cubeprefab, transform.position, transform.rotation);
        //Instantiate(Targetprefab, transform.position, transform.rotation);

        
    }

    

}
