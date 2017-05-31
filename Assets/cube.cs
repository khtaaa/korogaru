using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("Player")) {
			Application.LoadLevel ("title");

		}
	}
}
