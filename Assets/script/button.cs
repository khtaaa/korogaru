using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
	public void state()
	{
		Fade_Out.next="game";
		Fade_Out.fade_ok = true;
	}

}
