using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float ST;
	public bool floor;
	public Vector3 normal;
	// Use this for initialization
	void Start () {
		ST = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && floor == true) {
			this.GetComponent<Rigidbody> ().velocity = normal * 9.8f * 1.5f;
		}
	}
}
