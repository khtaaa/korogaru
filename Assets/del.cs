﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class del : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col) {
		if ((col.gameObject.CompareTag ("Player"))||(col.gameObject.CompareTag ("del")))
			Destroy (gameObject);
		}
}
