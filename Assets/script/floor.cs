using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour {
	public Material def;//デフォルトのマテリアル
	public Material red;//赤のマテリアル
	public Material blue;//青のマテリアル
	public Material yellow;//黄色のマテリアル
	public float time;//時間
	public Vector3 pos;//初期座標記憶
	public Vector3 posy;//移動先
	// Use this for initialization
	void Start () {
		pos = transform.position;//初期座標獲得
		posy = new Vector3 (pos.x, pos.y + 100f, pos.z);//初期座標の上100を獲得

	}
	
	// Update is called once per frame
	void Update () {
		//秒獲得
		time += Time.deltaTime;
		if (time > 6) {
			//時間リセット
			time = 0;
		}
		if ((int)time == 3) {
			transform.position = pos;//初期座標に移動

			//ボールが通るなら赤色に変更
			if (transform.position.x == manager.ballx || transform.position.z == manager.ballz
				||transform.position.x == manager.ballx2 || transform.position.z == manager.ballz2) {
				this.GetComponent<Renderer> ().material = red;
			} 


			//床が抜けるなら青に変更
			if (transform.position.x == manager.delx && transform.position.z == manager.delz
				|| transform.position.x == manager.delx2 && transform.position.z == manager.delz2) {
				this.GetComponent<Renderer> ().material = blue;
			}


			//キューブがくるなら黄色に変更
			if (transform.position.x == manager.cubex && transform.position.z == manager.cubez
				|| transform.position.x == manager.cubex2 && transform.position.z == manager.cubez2) {
				this.GetComponent<Renderer> ().material = yellow;
			}


		}
		if (time == 0) {
			this.GetComponent<Renderer> ().material = def;//色をデフォルトに変更
			//床が抜けるなら座標を移動先に変更
			if (transform.position.x == manager.delx && transform.position.z == manager.delz 
				|| transform.position.x == manager.delx2 && transform.position.z == manager.delz2) {
				this.transform.position = posy;
			}

		}
	}
}
