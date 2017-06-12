using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
	public GameObject ball;//ボールオブジェクト
	public GameObject cube;//キューブオブジェクト
	public GameObject SE;//効果音のオブジェクト
	public GameObject fly;//ジャンプ力アップのアイテム
	public GameObject work;//移動速度アップのアイテム
	public static int maxwave=0;//waveの最高記録
	public static int nowwave=0;//現在のwave
	public static int ballx;//ボールAの移動座標
	public static int ballz;//ボールBぼ移動座標
	public static int ballx2;//ボールCの移動座標
	public static int ballz2;//ボールDの移動座標
	public static int delx;//抜ける床Aの座標ｘ
	public static int delz;//抜ける床Aの座標ｚ
	public static int delx2;//抜ける床Bの座標ｘ
	public static int delz2;//抜ける床Bの座標ｚ
	public static int cubex;//キューブAの出現座標ｘ
	public static int cubez;//キューブAの出現座標ｚ
	public static int cubex2;//キューブBの出現座標ｘ
	public static int cubez2;//キューブBの出現座標ｚ
	public float instx;//最終的なボールの生成座標ｘ
	public float instz;//最終的なボールの生成座標ｚ
	public float time;//時間
	public int direction;//ボールの転がる方向
	public bool ok;//waveで一度だけ効果音を鳴らすために使用
	public int itemX;//アイテム生成座標ｘ
	public int itemZ;//アイテム生成座標ｚ
	// Use this for initialization
	void Start () {
		//初期化
		nowwave=0;
		ballx2 = 100;
		ballz2 = 100;
		delx = 100;
		delz = 100;
		delx2 = 100;
		delz2 = 100;
		cubex = 100;
		cubez = 100;
		cubex2 = 100;
		cubez2 = 100;
		ok = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (nowwave > maxwave) {
			maxwave = nowwave;
		}
		//秒を獲得
		time += Time.deltaTime;

		if (time >= 6) {
			ok = true;//一度だけリセット
			time = 0;//時間リセット
		}
		if ((int)time == 3 && ok==true) {
			SE.GetComponent<SE> ().koukaon (1);//効果音
			//2分の1でアイテム生成
			if (Random.value > 0.5) {
				itemX = (int)Random.Range (-2, 3) * 5;//アイテムのｘ座標をランダムで獲得
				itemZ = (int)Random.Range (-2, 3) * 5;//アイテムのｚ座標をランダムで獲得
				//2のアイテムのうちどっちかを生成
				if (Random.value > 0.5) {
					//ジャンプ力アップのアイテムの生成
					Instantiate (fly, new Vector3 (itemX, 10, itemZ), Quaternion.identity);
				} else {
					//移動速度アップのアイテム生成
					Instantiate (work, new Vector3 (itemX, 10, itemZ), Quaternion.identity);
				}
			}
			nowwave++;//wave増加
			ok = false;//一度だけ
		}
		if ((int)time == 2) {
			//ボールABのｘｚ座標をランダム獲得
			ballx = (int)Random.Range (-2, 3) * 5;
			ballz = (int)Random.Range (-2, 3) * 5;
			if (nowwave >= 5) {
				//ボールCDのｘｚ座標をランダム獲得
				ballx2 = (int)Random.Range (-2, 3) * 5;
				ballz2 = (int)Random.Range (-2, 3) * 5;
			}
			if (nowwave >=10) {
				//抜ける床Aのｘｚ座標をランダム獲得
				delx = (int)Random.Range (-2, 3) * 5;
				delz = (int)Random.Range (-2, 3) * 5;
			}
			if (nowwave >= 15) {
				//抜ける床Bのｘｚ座標をランダム獲得
				delx2 = (int)Random.Range (-2, 3) * 5;
				delz2 = (int)Random.Range (-2, 3) * 5;
			}

			if (nowwave >= 20) {
				//キューブAのｘｚ座標をランダム獲得
				cubex = (int)Random.Range (-2, 3) * 5;
				cubez = (int)Random.Range (-2, 3) * 5;
			}

			if (nowwave >=25) {
				//キューブBのｘｚ座標をランダム獲得
				cubex2 = (int)Random.Range (-2, 3) * 5;
				cubez2 = (int)Random.Range (-2, 3) * 5;
			}
		}
		if (time == 0) {
			//ボールAを生成
			inst (1);
			//ボールBを生成
			inst (2);
			if (nowwave > 5) {
				//ボールCを生成
				inst (3);
				//ボールDを生成
				inst (4);
			}

			if (nowwave > 20) {
				//キューブAを生成
				Instantiate (cube, new Vector3 (cubex, 10, cubez), Quaternion.identity);
			}

			if (nowwave > 25) {
				//キューブBを生成
				Instantiate (cube, new Vector3 (cubex2, 10, cubez2), Quaternion.identity);
			}
		}	
	}

	public void inst(int pos)
	{
		//方向を獲得
		if (Random.value < 0.5f) {
			direction = 1;
		} else {
			direction = -1;
		}

		//ボールAの座標を作成
		if (pos == 1) {
			instx = 15 * direction;
			instz = ballz;
		}

		//ボールBの座標を作成
		if (pos == 2) {
			instx = ballx;
			instz = 15 * direction;
		}

		//ボールCの座標を作成
		if (pos == 3) {
			instx = 15 * direction;
			instz = ballz2;
		}

		//ボールDの座標を作成
		if (pos == 4) {
			instx = ballx2;
			instz = 15 * direction;
		}

		//ボール生成
		GameObject INSball = Instantiate (ball, new Vector3 (instx, 3, instz),
				                    Quaternion.identity) as GameObject;
		INSball.GetComponent<sphere> ().hoge = direction * -1;//作成したボールの方向を指定
		INSball.GetComponent<sphere> ().pos = pos;//作成したボールの座標を指定
	}
}
