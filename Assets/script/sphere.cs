using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {
	public int pos;
	public float speed;
	public int hoge;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5f);
		speed = Random.Range (0.3f, 0.6f);
	}
	
	// Update is called once per frame
	void Update () {
		if (pos == 1) {
			transform.Translate (speed*hoge, 0f, 0f);
		}
		if (pos == 2) {
			transform.Translate (0f, 0f, speed*hoge);
		}
		if (pos == 3) {
			transform.Translate (speed*hoge, 0f, 0f);
		}
		if (pos == 4) {
			transform.Translate (0f, 0f, speed*hoge);
		}
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("Player")) {
			Application.LoadLevel ("title");

		}
	}
}
