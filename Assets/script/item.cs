using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {
	
	void OnCollisionEnter(Collision col) {
		//プレイヤーに触れるか下に落ちたら削除
		if ((col.gameObject.CompareTag ("Player"))||(col.gameObject.CompareTag ("del")))
			Destroy (gameObject);
	}
}
