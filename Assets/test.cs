using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.PageUp)) {
			manager.nowwave++;
		}

		if (Input.GetKeyDown (KeyCode.PageDown)) {
			manager.nowwave--;
		}

		if (Input.GetKeyDown (KeyCode.Keypad1)) {
			GameObject.Find ("player").GetComponent<player> ().fly += 0.5f;
		}
		if (Input.GetKeyDown (KeyCode.Keypad2)) {
			GameObject.Find ("player").GetComponent<player> ().work+=0.01f;
		}
	}
}
