﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodir : MonoBehaviour {

	public Cunj cunj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider otherCollider) {
		if (otherCollider.tag == "Pod") {
			cunj.OnTouchPod ();
		}
	}
}