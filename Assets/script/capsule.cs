using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule : MonoBehaviour {
	public float x;
	public float z;
	public float y;

	// Use this for initialization
	void Start () {
		x = transform.position.x;
		z = transform.position.z;
		y = -5f;
		Destroy (gameObject, 3f);//生成されてから3秒後に削除
	}
	
	// Update is called once per frame
	void Update () {
		//Y座標0になるまで少しずつ上に行く
		if (y < 0) {
			y += 0.1f;
		}
			this.transform.position =new Vector3 (x, y, z);
	}
}
