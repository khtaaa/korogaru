﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftControl)) {
			if (Input.GetKeyDown (KeyCode.T)) {
				this.transform.position = new Vector3 (0, 7, 0);
				this.GetComponent<Rigidbody>().useGravity = !this.GetComponent<Rigidbody>().useGravity;


			}
		}
	}
}
