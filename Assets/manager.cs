using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
	public static int wave=0;
	public int nowwave;
	public int lockwave;
	public int xx=5;
	public int zz=-10;
	public static int x;
	public static int z;
	public static int x2;
	public static int z2;
	public float px;
	public float pz;
	public float time;
	public GameObject ball;
	public int hoge;
	// Use this for initialization
	void Start () {
		//x = 5;
		//z = -10;
		nowwave=0;
	}
	
	// Update is called once per frame
	void Update () {
		if (nowwave > wave) {
			wave = nowwave;
		}
		lockwave = wave;
		time += Time.deltaTime;
		if (time >= 6) {
			nowwave++;
			time = 0;
		}

		if ((int)time == 2) {
			x = (int)Random.Range (-2, 2) * 5;
			z = (int)Random.Range (-2, 2) * 5;
			x2 = (int)Random.Range (-2, 2) * 5;
			z2 = (int)Random.Range (-2, 2) * 5;


		}
		if (time == 0) {
			inst (1);
			inst (2);
			inst (3);
			inst (4);
		}

		xx = x;
		zz = z;
		
	}

	public void inst(int pos)
	{

		if (Random.value < 0.5f) {
			hoge = 1;
		} else {
			hoge = -1;
		}
		if (pos == 1) {
			px = 10 * hoge;
			pz = z;
		}
		if (pos == 2) {
			px = x;
			pz = 10 * hoge;
		}
		if (pos == 3) {
			px = 10 * hoge;
			pz = z2;
		}
		if (pos == 4) {
			px = x2;
			pz = 10 * hoge;
		}
		GameObject INSball = Instantiate (ball, new Vector3 (px, 3, pz),
				                    Quaternion.identity) as GameObject;
			INSball.GetComponent<sphere> ().hoge = hoge * -1;
			INSball.GetComponent<sphere> ().pos = pos;


			
	}
}
