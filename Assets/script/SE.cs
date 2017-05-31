using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class SE : MonoBehaviour {
	public AudioClip[] seLists;
	AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource>();

	}
	
	public void koukaon(int i)
	{
		source.PlayOneShot (null);
		source.PlayOneShot(seLists[i]);
		return;
	}

}
