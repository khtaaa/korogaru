using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titletext : MonoBehaviour {
	void Start () {
		GetComponent<Text> ().text ="最高記録 "+ manager.maxwave+" wave";
	}
}
