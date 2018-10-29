﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmscript : MonoBehaviour {

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("bgm");
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

    }
}
