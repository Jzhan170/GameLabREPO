using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetspawn : MonoBehaviour {
    public bool spawnTarget;
    
    void Start () {
		
	}

    public void Init(bool targetSpawn)
    {
        spawnTarget = targetSpawn;

        Vector2 pos = Vector2.zero;

        if (targetSpawn)
        {
            pos = new Vector2(objectprefab.targetpos.x, 0);
            pos -= Vector2.right * transform.localScale.x;

           
        }
      }
    }
