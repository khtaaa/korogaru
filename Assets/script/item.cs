using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {
	
	void OnCollisionEnter(Collision col) {
		if ((col.gameObject.CompareTag ("Player"))||(col.gameObject.CompareTag ("del")))
			Destroy (gameObject);
	}
}
