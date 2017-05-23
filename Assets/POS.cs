using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POS : MonoBehaviour {
	public float rote;
	public GameObject player;
	Vector3 pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pos.x = player.transform.position.x;
		pos.y = player.transform.position.y + 5;
		pos.z = player.transform.position.z;

		this.transform.position = pos;
		rote = Input.GetAxis("Horizontal");
		transform.Rotate (0f, rote, 0f);

	}
}
