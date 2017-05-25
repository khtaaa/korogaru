using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour {
	public Material red;
	public Material def;
	public float time;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 6) {
			
			time = 0;
		}
		if ((int)time == 3) {
			if (transform.position.x == manager.x || transform.position.z == manager.z||transform.position.x == manager.x2 || transform.position.z == manager.z2) {
				this.GetComponent<Renderer> ().material = red;
			}
		}
		if (time == 0) {
			this.GetComponent<Renderer> ().material = def;
		}
	}
}
