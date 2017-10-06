using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wavetext : MonoBehaviour {
	void Update () {
		GetComponent<Text> ().text ="wave"+manager.nowwave;
	}
}
