using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereAnimation : MonoBehaviour {

    Animator anim;
    float dist;
    public GameObject cube;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	
	void Update () {
        dist = Vector3.Distance(cube.transform.position, transform.position);
        anim.SetFloat("doShake", dist);

        

	}
}
