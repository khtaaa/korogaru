using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3f);//生成されてから3秒後に削除
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col) {
		//プレイヤーにあたったらタイトルシーンに移動
		if (col.gameObject.CompareTag ("Player")) {
			Application.LoadLevel ("title");

		}
	}
}
