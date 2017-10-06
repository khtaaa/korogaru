using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour {
	public float x;

	void Start () {
		x=5f;
		Destroy (gameObject, 3f);
	}

	void Update () {
		x += 0.08f;
		this.transform.localScale = new Vector3 (x, 5f, 0.5f);
	}
}
