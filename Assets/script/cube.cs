using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3f);//生成されてから3秒後に削除
	}
}
