using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col) {
		//playerが触れたらタイトルに戻る
		if (col.gameObject.CompareTag ("Player")) {
			Application.LoadLevel ("title");

		}
	}
}
