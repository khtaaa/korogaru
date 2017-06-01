using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public GameObject SE;
	public float ST;
	public bool floor;
	public Vector3 normal;
	public float pos;
	public float rote;
	public float fly;
	public float work;
	// Use this for initialization
	void Start () {
		ST = 100;
		fly = 0;
	}
	
	// Update is called once per frame
	void Update () {
		pos = Input.GetAxis ("Vertical");
		rote = Input.GetAxis("Horizontal");
		transform.Rotate (0f, rote*1.2f, 0f);
		if (floor == false) {
			transform.Translate (0f, 0f, pos * (0.05f+work));
		}
		if (Input.GetKeyDown (KeyCode.Space) && floor == true) {
			this.GetComponent<Rigidbody> ().velocity = normal * (7f+fly);
			SE.GetComponent<SE> ().koukaon (0);
		}
	}

	//オブジェクトが衝突したとき
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("floor"))
			floor = true;
		if (col.gameObject.CompareTag ("fly"))
			fly+=0.5f;
		if (col.gameObject.CompareTag ("work"))
			work += 0.01f;
			
	}

	//オブジェクトが離れた時
	void OnCollisionExit(Collision col) {
		if (col.gameObject.CompareTag ("floor"))
			floor = false;
	}

	//オブジェクトが触れている間
	void OnCollisionStay(Collision col) {
		if (col.gameObject.CompareTag ("floor"))
			floor = true;
	}
}
