using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour {
	public int pos;//どのボールか判定
	public float speed;//移動速度
	public int hoge;//移動方向
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3f);//生成3秒後に削除
		speed = Random.Range (0.3f, 0.6f);//スピードをランダム獲得
	}
	
	// Update is called once per frame
	void Update () {
		//ボールごとに方向と移動を計算し加速
		if (pos == 1) {
			transform.Translate (speed*hoge, 0f, 0f);
		}
		if (pos == 2) {
			transform.Translate (0f, 0f, speed*hoge);
		}
		if (pos == 3) {
			transform.Translate (speed*hoge, 0f, 0f);
		}
		if (pos == 4) {
			transform.Translate (0f, 0f, speed*hoge);
		}
	}
}
