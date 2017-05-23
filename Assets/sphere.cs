using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {
	public bool AB;
	public float speed;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (AB == true) {
			transform.Translate (speed*-1, 0f, 0f);
		}
		if (AB == false) {
			transform.Translate (0f, 0f, speed*-1);
		}
	}
}
