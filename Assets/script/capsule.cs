using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour {
	public float x;
	public float z;
	public float y;

	void Start () {
		x = transform.position.x;
		z = transform.position.z;
		y = -5f;
		Destroy (gameObject, 3f);
	}

	void Update () {
		if (y < 0) 
			y += 0.1f;
		this.transform.position =new Vector3 (x, y, z);
	}
}
