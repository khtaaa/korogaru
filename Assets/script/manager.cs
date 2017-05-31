using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
	public static int wave=0;
	public GameObject cube;
	public static int nowwave=0;
	public int lockwave;
	public int xx=5;
	public int zz=-10;
	public static int x;
	public static int z;
	public static int x2;
	public static int z2;
	public static int delx;
	public static int delz;
	public static int delx2;
	public static int delz2;
	public static int cubex;
	public static int cubez;
	public static int cubex2;
	public static int cubez2;
	public float px;
	public float pz;
	public float time;
	public GameObject ball;
	public int hoge;
	public GameObject SE;
	public bool ok;
	// Use this for initialization
	void Start () {
		nowwave=0;
		x2 = 100;
		z2 = 100;
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
		if (nowwave > wave) {
			wave = nowwave;
		}
		lockwave = wave;
		time += Time.deltaTime;
		if (time >= 6) {
			
			ok = true;
			time = 0;
		}
		if ((int)time == 3 && ok==true) {
			SE.GetComponent<SE> ().koukaon (1);
			nowwave++;
			ok = false;
		}
		if ((int)time == 2) {
			x = (int)Random.Range (-2, 3) * 5;
			z = (int)Random.Range (-2, 3) * 5;
			if (nowwave >= 5) {
				x2 = (int)Random.Range (-2, 3) * 5;
				z2 = (int)Random.Range (-2, 3) * 5;
			}
			if (nowwave >=10) {
				delx = (int)Random.Range (-2, 3) * 5;
				delz = (int)Random.Range (-2, 3) * 5;
			}
			if (nowwave >= 15) {
				delx2 = (int)Random.Range (-2, 3) * 5;
				delz2 = (int)Random.Range (-2, 3) * 5;
			}

			if (nowwave >= 20) {
				cubex = (int)Random.Range (-2, 3) * 5;
				cubez = (int)Random.Range (-2, 3) * 5;
			}

			if (nowwave >=25) {
				cubex2 = (int)Random.Range (-2, 3) * 5;
				cubez2 = (int)Random.Range (-2, 3) * 5;
			}
		}
		if (time == 0) {
			inst (1);
			inst (2);
			if (nowwave > 5) {
				inst (3);
				inst (4);
			}

			if (nowwave > 20) {
				Instantiate (cube, new Vector3 (cubex, 10, cubez), Quaternion.identity);
			}

			if (nowwave > 25) {
				Instantiate (cube, new Vector3 (cubex2, 10, cubez2), Quaternion.identity);
			}
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
			px = 15 * hoge;
			pz = z;
		}
		if (pos == 2) {
			px = x;
			pz = 15 * hoge;
		}
		if (pos == 3) {
			px = 15 * hoge;
			pz = z2;
		}
		if (pos == 4) {
			px = x2;
			pz = 15 * hoge;
		}
		GameObject INSball = Instantiate (ball, new Vector3 (px, 3, pz),
				                    Quaternion.identity) as GameObject;
			INSball.GetComponent<sphere> ().hoge = hoge * -1;
			INSball.GetComponent<sphere> ().pos = pos;


			
	}
}
