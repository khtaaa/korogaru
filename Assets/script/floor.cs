using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour {
	public Material red;
	public Material blue;
	public Material def;
	public Material yellow;
	public float time;
	public Vector3 pos;
	public Vector3 posy;
	// Use this for initialization
	void Start () {
		pos = transform.position;
		posy = new Vector3 (pos.x, pos.y + 100f, pos.z);

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 6) {
			
			time = 0;
		}
		if ((int)time == 3) {
			transform.position = pos;
			if (transform.position.x == manager.x || transform.position.z == manager.z||transform.position.x == manager.x2 || transform.position.z == manager.z2) {
				this.GetComponent<Renderer> ().material = red;
			} 

			if (transform.position.x == manager.delx && transform.position.z == manager.delz|| transform.position.x == manager.delx2 && transform.position.z == manager.delz2) {
				this.GetComponent<Renderer> ().material = blue;
			}

			if (transform.position.x == manager.cubex && transform.position.z == manager.cubez|| transform.position.x == manager.cubex2 && transform.position.z == manager.cubez2) {
				this.GetComponent<Renderer> ().material = yellow;
			}


		}
		if (time == 0) {
			this.GetComponent<Renderer> ().material = def;
			if (transform.position.x == manager.delx && transform.position.z == manager.delz || transform.position.x == manager.delx2 && transform.position.z == manager.delz2) {
				this.transform.position = posy;
			}

		}
	}
}
