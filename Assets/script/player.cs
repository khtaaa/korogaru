using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public GameObject SE;//効果音
	public bool floor;//floorに触れているか
	public Vector3 normal;//どっちが上か
	public float pos;//WS
	public float rote;//AD
	public float fly;//ジャンプ追加
	public float work;//移動追加
	// Use this for initialization
	void Start () {
		fly = 0;
		work = 0;
	}
	
	// Update is called once per frame
	void Update () {
		pos = Input.GetAxis ("Vertical");
		rote = Input.GetAxis("Horizontal");

		//視点回転
		transform.Rotate (0f, rote*1.5f, 0f);

		//空中にいるとき前後移動
		if (floor == false) {
			transform.Translate (0f, 0f, pos * (0.05f+work));
		}

		//floorに触れているときスペースでジャンプ
		if (Input.GetKeyDown (KeyCode.Space) && floor == true) {
			this.GetComponent<Rigidbody> ().velocity = normal * (7f+fly);
			SE.GetComponent<SE> ().koukaon (0);
		}
	}

	//オブジェクトが衝突したとき
	void OnCollisionEnter(Collision col) {
		
		//床に触れた
		if (col.gameObject.CompareTag ("floor"))
			floor = true;
		
		//ジャンプ力アップアイテムを獲得した
		if (col.gameObject.CompareTag ("fly"))
			fly+=0.2f;
		
		//移動速度アップアイテムを獲得した
		if (col.gameObject.CompareTag ("work"))
			work += 0.005f;

		//障害物にあたったるか下に落ちたらタイトルシーンに移動
		if ((col.gameObject.CompareTag ("del"))||(col.gameObject.CompareTag ("enemy"))) {
			Application.LoadLevel ("title");

		}
			
	}

	//オブジェクトが離れた時
	void OnCollisionExit(Collision col) {
		//床から離れた
		if (col.gameObject.CompareTag ("floor"))
			floor = false;
	}

	//オブジェクトが触れている間
	void OnCollisionStay(Collision col) {
		//床に触れている
		if (col.gameObject.CompareTag ("floor"))
			floor = true;
	}
}
