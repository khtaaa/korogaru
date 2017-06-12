using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titletext : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text ="最高記録 "+ manager.maxwave+" wave";

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
