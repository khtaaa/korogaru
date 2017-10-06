using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public GameObject SE;//効果音
	public GameObject BGM;//BGM
	public AudioClip[] BGMLists;
	public bool floor;//floorに触れているか
	public Vector3 normal;//どっちが上か
	public float pos;//WS
	public float rote;//AD
	public float fly;//ジャンプ追加
	public float work;//移動追加
	public bool gameover;//ゲームオーバー
	public GameObject gameover_text;

	void Start () {
		fly = 0;
		work = 0;
		gameover = false;
		gameover_text.transform.localPosition =new Vector3(0,-300,0);
		BGM.GetComponent<AudioSource>().PlayOneShot (null);
		BGM.GetComponent<AudioSource>().PlayOneShot(BGMLists[0]);
	}

	void Update () {
		if (gameover == false) {
			pos = Input.GetAxis ("Vertical");
			rote = Input.GetAxis ("Horizontal");

			//視点回転
			transform.Rotate (0f, rote * 1.5f, 0f);

			//空中にいるとき前後移動
			if (floor == false) {
				transform.Translate (0f, 0f, pos * (0.05f + work));
			}

			//floorに触れているときスペースでジャンプ
			if (Input.GetKeyDown (KeyCode.Space) && floor == true) {
				this.GetComponent<Rigidbody> ().velocity = normal * (7f + fly);
				SE.GetComponent<SE> ().koukaon (0);
			}

		}
		if (gameover == true) {
			if (gameover_text.transform.localPosition.y < 0)
				gameover_text.transform.localPosition+=Vector3.up*2;
			if (Input.GetMouseButtonDown (0)) {
				Fade_Out.next = "title";
				Fade_Out.fade_ok = true;
			}
		}
	}

	//オブジェクトが衝突したとき
	void OnCollisionEnter(Collision col) {
		
		//床に触れた
		if (col.gameObject.CompareTag ("floor"))
			floor = true;
		
		//ジャンプ力アップアイテムを獲得した
		if (col.gameObject.CompareTag ("fly")) {
			fly += 0.2f;
			SE.GetComponent<SE> ().koukaon (2);
		}
		
		//移動速度アップアイテムを獲得した
		if (col.gameObject.CompareTag ("work")) {
			work += 0.005f;
			SE.GetComponent<SE> ().koukaon (2);
		}

		//障害物にあたったるか下に落ちたらタイトルシーンに移動
		if ((col.gameObject.CompareTag ("del")) || (col.gameObject.CompareTag ("enemy"))) {
			this.GetComponent<Rigidbody> ().useGravity = false;
			this.GetComponent<BoxCollider> ().isTrigger = true;
			this.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
			this.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			BGM.GetComponent<AudioSource> ().Stop();
			BGM.GetComponent<AudioSource>().PlayOneShot(BGMLists[1]);
			gameover = true;
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
