using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
	public int xx=5;
	public int zz=-10;
	public static int x;
	public static int z;
	public float time;
	public GameObject sphere;
	// Use this for initialization
	void Start () {
		x = 5;
		z = -10;

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time >= 6) {
			x = (int)Random.Range (-2, 2) * 5;
			z = (int)Random.Range (-2, 2) * 5;
			time = 0;
		}
		if (time >= 3) {
			Instantiate (sphere, new Vector3 (10, 3, z), Quaternion.identity);
		}

		xx = x;
		zz = z;
		
	}
}
