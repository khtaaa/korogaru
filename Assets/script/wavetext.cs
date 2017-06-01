using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wavetext : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text ="wave"+manager.nowwave;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text ="wave"+manager.nowwave;
	}
}
